/****** Script for SelectTopNRows command from SSMS  ******/
SELECT do.label_name, sy.name1	, sy.name2	, sy.name3	, sy.name4	, sy.name5	, sy.name6	, sy.name7	, sy.name8	, sy.name9	, sy.name10	, sy.name11	, sy.name12	, sy.name13	, sy.name14	, sy.name15	, sy.name16	, sy.name17	, sy.name18	, sy.name19	, sy.name20

  FROM [DomainDb].[dbo].[synonym_details] as sd inner join synonym as sy on sd.synonym_id = sy.synonym_id inner join domain as do on sd.domain_id = do.domain_id
  order by name1 desc

  delete from synonym_details