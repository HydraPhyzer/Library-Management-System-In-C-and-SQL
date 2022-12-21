create Table Login(
	Username Varchar(150) not Null,
	Password Varchar (20) not Null,
);
Insert into Login (Username,Password) Values ('Admin','Admin');
Select * From Login

create Table AddNewBook(
	BookName Varchar (150) not Null,
	ISBN Varchar (150) not Null Primary Key,
	PublishDate Varchar (150) not Null,
	Category Varchar (150) not Null,
	Quantity Int not Null,
	AuthorName varchar(255),
);
Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity) Values ('C++','Athar Rehman','123','12/12/2021','Coding',10);
--Select * From AddNewBook;
--Delete from AddNewBook;

create Table AddUser(
	UserName Varchar (150) not Null,
	UserID Varchar (150) not Null Primary Key,
	UserContact Varchar (150) not Null, 
	UserEmail Varchar (150) not Null
);
--Select * From AddUser;
--Delete From AddUser

create Table IssueBook(
	UserID Varchar (150) Foreign Key References AddUser(UserID) Not Null,
	ISBN Varchar (150) Foreign Key References AddNewBook(ISBN) Not Null,
	IssueDate Varchar (150) not Null,
	ReturnDate Varchar (150) not Null,
	IsReturned Bit not Null,
	Fine Int not Null,
	Foreign Key (UserID) References AddUser on Delete Cascade,
	Foreign Key (ISBN) References AddNewBook on Delete Cascade
);
--Delete From IssueBook
Select * From IssueBook

Insert into AddUser(UserName,UserID,UserContact,UserEmail) values('Qasim Boota','78','45678','alibaba278278@gmail.com')

--Select Useremail from AddUser where Useremail != '' and UserEmail LIKE '%@%.%'
--Select * from IssueBook where IsReturned=0'
--Select IB.UserID ,AU.UserName,IB.ISBN,IB.IssueDate,IB.ReturnDate,IB.IsReturned,IB.Fine from IssueBook IB inner join AddUser AS AU on IB.UserID=AU.UserID and IB.UserID= 'XXXX-YY-Z' ; 
--Update IssueBook Set Fine=0 where UserID='XXXX-YY-Z'  

--Select Count(*) FROM IssueBook where UserID = '2020-CS-601' and IsReturned != 0
--Select Count(*) from IssueBook where ISBN = '123' and UserID='2020-CS-601'
--Select Sum(Fine) From IssueBook Where UserID='XXXX-YY-Z'
--SELECT DATEDIFF(DAY,'2017/12/12','2020/12/12') AS DATEDIF

--Update IssueBook Set Fine=0 ,IsReturned=1 Where UserID=UserID And ISBN=ISBN and IsReturned=0 and Fine>0;
--Select IB.Fine,IB.ISBN,AU.UserID,AB.BookName from IssueBook as IB Inner Join AddNewBook as AB on IB.ISBN=AB.ISBN Inner Join AddUser as AU on AU.UserID=IB.UserID and IB.UserID='XXXX-YY-Z' and IB.Fine>0;

--Select UserEmail,UserName From AddUser Where UserEmail Like '%@%.%'


Select AB.BookName, Count(AB.BookName) From IssueBook as IB Inner Join AddNewBook as AB ON IB.ISBN=AB.ISBN and IB.IsReturned=0 Group By AB.BookName