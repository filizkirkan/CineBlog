CREATE DATABASE CinemaBlog
GO
USE CinemaBlog
GO
CREATE TABLE AdminTypes 
(
    ID int IDENTITY(1,1),
	Name nvarchar(50) NOT NULL,
	CONSTRAINT pk_adminType PRIMARY KEY(ID)
  
  --statu;
  --1, meaning the post is in draft and is not visible to public;
  --2, meaning the post is published to public;
  --3, meaning the post is outdated and is not visible in the post list (still accessible individually, though).

)
GO
INSERT INTO AdminTypes(Name) VALUES('Admin')
INSERT INTO AdminTypes(Name) VALUES('Moderator')
GO
CREATE TABLE Admins
(
	ID int IDENTITY(1,1),
	AdminTypeID int,
	Name nvarchar(50) NOT NULL,
	Lastname nvarchar(50),
	Email nvarchar(120),
	Password nvarchar(20),
	Statu bit,
	CONSTRAINT pk_admin PRIMARY KEY(ID),
	CONSTRAINT pk_adminAdminType FOREIGN KEY(AdminTypeID)
	REFERENCES AdminTypes(ID)
)
GO
CREATE TABLE Users
(
	ID int IDENTITY(1,1),
	Name nvarchar(50) NOT NULL,
	Lastname nvarchar(50),
	Username nvarchar(20),
	Email nvarchar(120),
	Password nvarchar(20),
	MembershipDate datetime,
	Statu bit,
	CONSTRAINT pk_user PRIMARY KEY(ID),
)
GO
CREATE TABLE Categories
(
	ID int IDENTITY(1,1),
	Name nvarchar(50) NOT NULL,
	Statu bit,
	CONSTRAINT pk_category PRIMARY KEY(ID)
)
GO
CREATE TABLE Articles
(
	ID int IDENTITY(1,1),
	CategoryID int,
	AuthorID int,
	Topic nvarchar(120) NOT NULL,
	Summary nvarchar(500),
	Content nvarchar(MAX),
	Numberofviews int,
	Coverphoto nvarchar(50),
	Installeddate datetime,
	Statu bit,
	CONSTRAINT pk_article PRIMARY KEY(ID),
	CONSTRAINT fk_articleCategory FOREIGN KEY(CategoryID) REFERENCES Categories(ID),
	CONSTRAINT fk_articleAdmin FOREIGN KEY(AuthorID) REFERENCES Admins(ID)
)
 GO
CREATE TABLE Commentts /*nasi exist??*/
(
	ID int IDENTITY(1,1),
	ArticleID int,
	UserID int,
	Content nvarchar(500),
	Installeddate date,
	Statu bit,
	CONSTRAINT pk_comment PRIMARY KEY(ID),
	CONSTRAINT fk_commentArticle FOREIGN KEY(ArticleID) REFERENCES Articles(ID),
	CONSTRAINT fk_commentUser FOREIGN KEY(UserID) REFERENCES Users(ID)
)
 


