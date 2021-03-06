INSERT Basketball.Game(DateTimeInfo, RoundID)
SELECT Games.DateTimeInfo, R.RoundID
FROM
(
	VALUES
	 ('2022-03-17 12:00:00', N'First Round'),
	 ('2022-03-17 12:30:00', N'First Round'),
	 ('2022-03-17 13:00:00', N'First Round'),
	 ('2022-03-17 13:30:00', N'First Round'),
	 ('2022-03-17 14:00:00', N'First Round'),
	 ('2022-03-17 14:30:00', N'First Round'),
	 ('2022-03-17 15:00:00', N'First Round'),
	 ('2022-03-17 15:30:00', N'First Round'),
	 ('2022-03-17 16:00:00', N'First Round'),
	 ('2022-03-17 16:30:00', N'First Round'),
	 ('2022-03-17 17:00:00', N'First Round'),
	 ('2022-03-17 17:30:00', N'First Round'),
	 ('2022-03-17 18:00:00', N'First Round'),
	 ('2022-03-17 18:30:00', N'First Round'),
	 ('2022-03-17 19:00:00', N'First Round'),
	 ('2022-03-17 19:30:00', N'First Round'),
	 ('2022-03-18 12:00:00', N'First Round'),
	 ('2022-03-18 12:30:00', N'First Round'),
	 ('2022-03-18 13:00:00', N'First Round'),
	 ('2022-03-18 13:30:00', N'First Round'),
	 ('2022-03-18 14:00:00', N'First Round'),
	 ('2022-03-18 14:30:00', N'First Round'),
	 ('2022-03-18 15:00:00', N'First Round'),
	 ('2022-03-18 15:30:00', N'First Round'),
	 ('2022-03-18 16:00:00', N'First Round'),
	 ('2022-03-18 16:30:00', N'First Round'),
	 ('2022-03-18 17:00:00', N'First Round'),
	 ('2022-03-18 17:30:00', N'First Round'),
	 ('2022-03-18 18:00:00', N'First Round'),
	 ('2022-03-18 18:30:00', N'First Round'),
	 ('2022-03-18 19:00:00', N'First Round'),
	 ('2022-03-18 19:30:00', N'First Round'),
	 ('2022-03-19 13:00:00', N'Second Round'),
	 ('2022-03-19 13:30:00', N'Second Round'),
	 ('2022-03-19 14:00:00', N'Second Round'),
	 ('2022-03-19 14:30:00', N'Second Round'),
	 ('2022-03-19 15:00:00', N'Second Round'),
	 ('2022-03-19 15:30:00', N'Second Round'),
	 ('2022-03-19 16:00:00', N'Second Round'),
	 ('2022-03-19 16:30:00', N'Second Round'),
	 ('2022-03-20 13:00:00', N'Second Round'),
	 ('2022-03-20 13:30:00', N'Second Round'),
	 ('2022-03-20 14:00:00', N'Second Round'),
	 ('2022-03-20 14:30:00', N'Second Round'),
	 ('2022-03-20 15:00:00', N'Second Round'),
	 ('2022-03-20 15:30:00', N'Second Round'),
	 ('2022-03-20 16:00:00', N'Second Round'),
	 ('2022-03-20 16:30:00', N'Second Round'),
	 ('2022-03-24 14:00:00', N'Sweet 16'),
	 ('2022-03-24 15:00:00', N'Sweet 16'),
	 ('2022-03-24 16:00:00', N'Sweet 16'),
	 ('2022-03-24 17:00:00', N'Sweet 16'),
	 ('2022-03-25 14:00:00', N'Sweet 16'),
	 ('2022-03-25 15:00:00', N'Sweet 16'),
	 ('2022-03-25 16:00:00', N'Sweet 16'),
	 ('2022-03-25 17:00:00', N'Sweet 16'),
	 ('2022-03-26 15:00:00', N'Elite 8'),
	 ('2022-03-26 17:00:00', N'Elite 8'),
	 ('2022-03-27 15:00:00', N'Elite 8'),
	 ('2022-03-27 17:00:00', N'Elite 8'),
	 ('2022-04-02 17:00:00', N'Final 4'),
	 ('2022-04-02 19:00:00', N'Final 4'),
	 ('2022-04-04 20:00:00', N'National Championship')
) Games(DateTimeInfo, [Round])
INNER JOIN Basketball.[Round] R ON R.[Name] = Games.[Round]

