The aim of this exercise is to refactor a small, tightly coupled ASP.NET MVC3 app so that as many dependencies as possible are removed. You should also apply Unit tests to the project where necessary. If you spot any other opportunities to improve the code than please do so.
Create a Sql Server Database called QuoteDB and add a table called 'Quotes'

Run the following SQL Against QuoteDB

USE [QuoteDB]
GO

/****** Object:  Table [dbo].[Quotes]    Script Date: 08/08/2011 18:25:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Quotes](
	[QuoteID] [int] IDENTITY(1,1) NOT NULL,
	[QuoteText] [nvarchar](max) NULL,
	[QuoteAuthor] [nvarchar](100) NULL,
 CONSTRAINT [PK_Quotes] PRIMARY KEY CLUSTERED 
(
	[QuoteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


The application  has one controller called 'QuoteController' and two public actions in the QuoteController named 'Index', and 'RandomQuote.' There is a also a private method in the controller that returns the amount of records in the Quotes Table.

Data access is done via Entity Framework 4.1.
There is a skeleton test project that has a FakeQuotes Repository for you to use in the Unit tests if you need it. You can whatever test framework you like for the exercise.


you have 40 minutes to implement as much of the above as possible.