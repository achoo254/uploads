/****** Script for SelectTopNRows command from SSMS  ******/
with t as (SELECT case when month(date_inject) = 1 then count(inject) else 0 end as 'month1',
case when month(date_inject) = 2 then count(inject) else 0 end as 'month2',
case when month(date_inject) = 3 then count(inject) else 0 end as 'month3',
case when month(date_inject) = 4 then count(inject) else 0 end as 'month4',
case when month(date_inject) = 5 then count(inject) else 0 end as 'month5',
case when month(date_inject) = 6 then count(inject) else 0 end as 'month6',
case when month(date_inject) = 7 then count(inject) else 0 end as 'month7',
case when month(date_inject) = 8 then count(inject) else 0 end as 'month8',
case when month(date_inject) = 9 then count(inject) else 0 end as 'month9',
case when month(date_inject) = 10 then count(inject) else 0 end as 'month10',
case when month(date_inject) = 11 then count(inject) else 0 end as 'month11',
case when month(date_inject) = 12 then count(inject) else 0 end as 'month12'
  FROM [QuanLyVacXin].[dbo].[regimen_details] where year(date_inject) = 2020 and inject = 0  group by month(date_inject))
select sum(month1) as month1, sum(month2) as month2, sum(month3) as month3, sum(month4) as month4, sum(month5) as month5, sum(month6) as month6, sum(month7) as month7, sum(month8) as month8, sum(month9) as month9, sum(month10) as month10, sum(month11) as month11, sum(month12) as month12 from t