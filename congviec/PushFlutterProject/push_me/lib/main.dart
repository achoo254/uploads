import 'dart:convert';

import 'package:firebase_messaging/firebase_messaging.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

Future<Domain> fetchDomain(String domain) async {
  final response = await http
      .get(Uri.https('whois.inet.vn', 'api/whois/domainspecify/' + domain));

  if (response.statusCode == 200) {
    // If the server did return a 200 OK response,
    // then parse the JSON.
    return Domain.fromJson(jsonDecode(response.body));
  } else {
    // If the server did not return a 200 OK response,
    // then throw an exception.
    throw Exception('Failed to load...');
  }
}

class Domain {
  final String message;
  final String domainName;
  final String expirationDate;

  Domain({this.message, this.domainName, this.expirationDate});

  factory Domain.fromJson(Map<String, dynamic> json) {
    return Domain(
      message: json['message'].toString(),
      domainName: json['domainName'].toString(),
      expirationDate: json['expirationDate'].toString(),
    );
  }
}

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: Text('Push me'),
        ),
        body: Center(
          child: HomeScreen(),
        ),
      ),
    );
  }
}

class HomeScreen extends StatefulWidget {
  HomeScreenState createState() => HomeScreenState();
}

class HomeScreenState extends State<HomeScreen> {
  final domain = new TextEditingController();
  final FirebaseMessaging _firebaseMessaging = FirebaseMessaging();
  String _message = '';

  _registerOnFirebase() {
    _firebaseMessaging.subscribeToTopic('all');
    _firebaseMessaging.getToken().then((token) => print(token));
  }

  @override
  void initState() {
    _registerOnFirebase();
    getMessage();
    super.initState();
  }

  void getMessage() {
    _firebaseMessaging.configure(
        onMessage: (Map<String, dynamic> message) async {
      print('received message');
      setState(() => _message = message["notification"]["body"]);
    }, onResume: (Map<String, dynamic> message) async {
      print('on resume $message');
      setState(() => _message = message["notification"]["body"]);
    }, onLaunch: (Map<String, dynamic> message) async {
      print('on launch $message');
      setState(() => _message = message["notification"]["body"]);
    });
  }

  getItemAndResult(BuildContext context) {
    Navigator.push(
        context,
        MaterialPageRoute(
            builder: (builder) => SecondPage(domainHolder: domain.text)));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          children: <Widget>[
            Container(
              width: 280,
              padding: EdgeInsets.all(10.0),
              child: TextField(
                controller: domain,
                decoration: InputDecoration(
                  hintText: 'Nhập tên miền',
                ),
              ),
            ),
            Text("Message: $_message"),
            // ignore: deprecated_member_use
            RaisedButton(
              onPressed: () => getItemAndResult(context),
              color: Color(0xFF005DE9),
              textColor: Colors.white,
              padding: EdgeInsets.fromLTRB(10, 10, 10, 10),
              child: Text('Tìm kiếm...'),
            )
          ],
        ),
      ),
    );
  }
}

class SecondPage extends StatelessWidget {
  final domainHolder;
  const SecondPage({Key key, this.domainHolder}) : super(key: key);

  goBack(BuildContext context) {
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Kết quả: $domainHolder'),
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          FutureBuilder<Domain>(
              future: fetchDomain(domainHolder),
              builder: (context, snapshot) {
                if (snapshot.hasData) {
                  Domain domain = snapshot.data;
                  return Center(
                      child: Column(
                    children: <Widget>[
                      Text(
                        'Trạng thái:' + domain.message,
                        style: TextStyle(fontSize: 22),
                        textAlign: TextAlign.center,
                      ),
                      Text(
                        'Tên miền:' + domain.domainName,
                        style: TextStyle(fontSize: 22),
                        textAlign: TextAlign.center,
                      ),
                      Text(
                        'Ngày hết hạn:' + domain.expirationDate,
                        style: TextStyle(fontSize: 22),
                        textAlign: TextAlign.center,
                      ),
                      // ignore: deprecated_member_use
                      RaisedButton(
                        onPressed: () => goBack(context),
                        color: Color(0xFF005DE9),
                        textColor: Colors.white,
                        padding: EdgeInsets.fromLTRB(10, 10, 10, 10),
                        child: Text('Quay lại tìm kiếm'),
                      )
                    ],
                  ));
                }
                return Center(child: CircularProgressIndicator());
              }),
        ],
      ),
    );
  }
}
