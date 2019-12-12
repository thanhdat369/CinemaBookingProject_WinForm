USE CinemaDB
Create table Room
(
	RoomID int identity(1,1) primary key,
	RoomName nvarchar(50) not null,
	RoomDescription nvarchar(MAX),
	TimeCreate datetime default GETDATE(),
	IsAvailable bit,
)
Create table Movie
(
	MovieID int identity(1,1) primary key,
	MovieName nvarchar(250) not null,
	MovieDescription nvarchar(MAX),
	MovieDuration int not null,
	ImageLink nvarchar(200),
	IsAvailable  bit not null,
)

Create table MovieTime(
	MovieTimeID int identity(1,1) primary key,
	RoomID int references Room(RoomID),
	MovieID int references Movie(MovieID),
	StartTime datetime not null,
	EndTime datetime not null,
	IsAvailable bit default 'true',
)

Select * from MovieTime


CREATE PROC GET_TIME_OF_MOVIE_PROC(@Time DateTime,@MovieID int)
AS
BEGIN
Select MVT.MovieTimeID,MVT.StartTime,MVT.EndTime,
MV.MovieName as MovieName
from MovieTime as MVT 
LEFT JOIN Movie as MV  ON MV.MovieID = MVT.MovieID
WHERE MVT.StartTime BETWEEN @Time AND (DATEADD(d,0,DATEDIFF(d,0,@Time)+1))
AND MVT.MovieID = @MovieID
END;




CREATE PROC GET_MOVIE_BY_DAY_PROC(@Time DateTime)
AS
BEGIN
Select MV.MovieID,MV.MovieName,MV.MovieDescription,MV.MovieDuration,MV.ImageLink
from  Movie as MV
RIGHT JOIN MovieTime as MVT ON MV.MovieID = MVT.MovieID
WHERE MVT.StartTime BETWEEN @Time AND (DATEADD(d,0,DATEDIFF(d,0,@Time)+1)) AND MV.IsAvailable=1
GROUP BY MV.MovieID,MV.MovieName,MV.MovieDescription,Mv.MovieDuration,MV.ImageLink
ORDER BY MV.MovieID
END



SELECT RoomID,RoomName,RoomDescription FROM Room Where IsAvailable = 1;


Insert into MovieTime(MovieID,RoomID,StartTime,EndTime) values(@MovieID,@RoomID,@StartTime,@EndTime)


-- Ham kiem tra co phim nao da chieu trong do 
CREATE PROC CHECK_CONFLICT_TIME(@StartTime datetime,@EndTime datetime,@RoomID int)
AS 
BEGIN
SELECT MovieTimeID FROM MovieTime where ((@StartTime BETWEEN StartTime AND EndTime)
OR (StartTime BETWEEN @StartTime AND @EndTime)) AND RoomID = @RoomID AND IsAvailable = 1    
END
