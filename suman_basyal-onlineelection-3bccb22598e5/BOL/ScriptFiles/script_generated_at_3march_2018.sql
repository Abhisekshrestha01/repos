USE [ElectionDB]
GO
/****** Object:  Table [dbo].[CandidateElection]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CandidateElection](
	[electionId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[isApproved] [bit] NOT NULL,
	[datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_CandidateElection] PRIMARY KEY CLUSTERED 
(
	[electionId] ASC,
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CapableVoter]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapableVoter](
	[electionId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_RequestElectionVoter] PRIMARY KEY CLUSTERED 
(
	[electionId] ASC,
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Election]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Election](
	[electionId] [int] IDENTITY(1,1) NOT NULL,
	[electionName] [nvarchar](50) NOT NULL,
	[adminId] [int] NOT NULL,
	[endDate] [datetime] NOT NULL,
	[startDate] [datetime] NOT NULL,
	[votingRequestDeadline] [datetime] NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[electionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ElectionResult]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectionResult](
	[electionId] [int] NOT NULL,
	[winnerId] [int] NOT NULL,
	[totalVotes] [int] NULL,
	[datetime] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Notification]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notification](
	[notId] [int] IDENTITY(1,1) NOT NULL,
	[message] [nvarchar](50) NOT NULL,
	[url] [nvarchar](50) NOT NULL,
	[unseen] [bit] NOT NULL,
	[userId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[notId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VoterElection]    Script Date: 3/6/2018 1:54:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VoterElection](
	[voterId] [int] NOT NULL,
	[electionId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_VoterElection] PRIMARY KEY CLUSTERED 
(
	[voterId] ASC,
	[electionId] ASC,
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (10, 2, 1, CAST(N'2018-02-28T02:57:51.020' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (10, 3, 1, CAST(N'2018-02-28T02:57:51.030' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (10, 4, 1, CAST(N'2018-02-28T02:57:51.030' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (11, 17, 1, CAST(N'2018-02-28T03:38:07.367' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (11, 18, 1, CAST(N'2018-02-28T03:38:07.400' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (11, 19, 1, CAST(N'2018-02-28T03:38:07.403' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (12, 1, 1, CAST(N'2018-02-28T03:46:07.423' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (12, 2, 1, CAST(N'2018-02-28T03:46:07.427' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (13, 2, 1, CAST(N'2018-03-01T14:31:02.337' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (13, 3, 1, CAST(N'2018-03-01T14:31:02.390' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (14, 2, 1, CAST(N'2018-03-02T01:29:44.913' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (14, 3, 1, CAST(N'2018-03-02T01:29:44.950' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (15, 2, 1, CAST(N'2018-03-05T21:13:14.143' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (15, 3, 1, CAST(N'2018-03-05T21:13:14.153' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (15, 4, 1, CAST(N'2018-03-05T21:13:14.153' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (16, 1, 1, CAST(N'2018-03-05T21:36:47.877' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (16, 2, 1, CAST(N'2018-03-05T21:36:47.900' AS DateTime))
INSERT [dbo].[CandidateElection] ([electionId], [userId], [isApproved], [datetime]) VALUES (16, 3, 1, CAST(N'2018-03-05T21:36:47.903' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 10, CAST(N'2018-02-28T02:57:51.030' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 11, CAST(N'2018-02-28T02:57:51.057' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 12, CAST(N'2018-02-28T02:57:51.060' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 13, CAST(N'2018-02-28T02:57:51.060' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 14, CAST(N'2018-02-28T02:57:51.063' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (10, 15, CAST(N'2018-02-28T02:57:51.070' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (11, 2, CAST(N'2018-02-28T03:38:07.403' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (11, 3, CAST(N'2018-02-28T03:38:07.410' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (11, 4, CAST(N'2018-02-28T03:38:07.410' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (11, 5, CAST(N'2018-02-28T03:38:07.413' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (12, 12, CAST(N'2018-02-28T03:46:07.430' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (12, 13, CAST(N'2018-02-28T03:46:07.433' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (12, 14, CAST(N'2018-02-28T03:46:07.433' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (13, 9, CAST(N'2018-03-01T14:31:02.403' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (13, 10, CAST(N'2018-03-01T14:31:02.433' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (13, 11, CAST(N'2018-03-01T14:31:02.437' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (14, 4, CAST(N'2018-03-02T01:29:44.950' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (14, 5, CAST(N'2018-03-02T01:29:44.970' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (14, 6, CAST(N'2018-03-02T01:29:44.970' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (14, 7, CAST(N'2018-03-02T01:29:44.973' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (15, 5, CAST(N'2018-03-05T21:13:14.157' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (15, 6, CAST(N'2018-03-05T21:13:14.160' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (15, 7, CAST(N'2018-03-05T21:13:14.163' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (15, 12, CAST(N'2018-03-05T21:13:14.163' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (16, 4, CAST(N'2018-03-05T21:36:47.903' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (16, 5, CAST(N'2018-03-05T21:36:47.910' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (16, 7, CAST(N'2018-03-05T21:36:47.910' AS DateTime))
INSERT [dbo].[CapableVoter] ([electionId], [userId], [datetime]) VALUES (16, 9, CAST(N'2018-03-05T21:36:47.910' AS DateTime))
SET IDENTITY_INSERT [dbo].[Election] ON 

INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (10, N'monitor', 1, CAST(N'2018-02-28T03:05:00.000' AS DateTime), CAST(N'2018-02-28T02:56:00.000' AS DateTime), NULL, N'hi')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (11, N'president', 1, CAST(N'2018-02-28T03:39:00.000' AS DateTime), CAST(N'2018-02-28T03:37:00.000' AS DateTime), NULL, N'hi')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (12, N'captain', 5, CAST(N'2018-02-28T03:30:00.000' AS DateTime), CAST(N'2018-02-28T03:33:00.000' AS DateTime), NULL, N'hi')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (13, N'class caption', 1, CAST(N'2018-12-12T14:02:00.000' AS DateTime), CAST(N'2018-12-12T13:01:00.000' AS DateTime), NULL, N'test')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (14, N'test election', 1, CAST(N'2018-12-31T13:14:00.000' AS DateTime), CAST(N'2018-12-31T12:59:00.000' AS DateTime), NULL, N'tet')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (15, N'hero of lamar', 1, CAST(N'2018-01-01T01:08:00.000' AS DateTime), CAST(N'2018-01-01T01:00:00.000' AS DateTime), NULL, N'There has to be a compitetion to find the hero of lamar. ')
INSERT [dbo].[Election] ([electionId], [electionName], [adminId], [endDate], [startDate], [votingRequestDeadline], [Description]) VALUES (16, N'finding the laziest person', 6, CAST(N'2018-12-31T13:05:00.000' AS DateTime), CAST(N'2018-12-31T12:59:00.000' AS DateTime), NULL, N'the election is to find the laziest person in lamar university')
SET IDENTITY_INSERT [dbo].[Election] OFF
SET IDENTITY_INSERT [dbo].[Notification] ON 

INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (10, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 10)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (11, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 11)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (12, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 12)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (13, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 13)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (14, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 14)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (15, N'Please cast vote for monitor', N'Election/CastVote?electionId=10', 1, 15)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (16, N'You are candidate for monitor', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (17, N'You are candidate for monitor', N'temp', 1, 3)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (18, N'You are candidate for monitor', N'temp', 1, 4)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (19, N'Please cast vote for president', N'Election/CastVote?electionId=11', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (20, N'Please cast vote for president', N'Election/CastVote?electionId=11', 1, 3)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (21, N'Please cast vote for president', N'Election/CastVote?electionId=11', 1, 4)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (22, N'Please cast vote for president', N'Election/CastVote?electionId=11', 1, 5)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (23, N'You are candidate for president', N'temp', 1, 17)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (24, N'You are candidate for president', N'temp', 1, 18)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (25, N'You are candidate for president', N'temp', 1, 19)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (26, N'Please cast vote for captain', N'Election/CastVote?electionId=12', 1, 12)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (27, N'Please cast vote for captain', N'Election/CastVote?electionId=12', 1, 13)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (28, N'Please cast vote for captain', N'Election/CastVote?electionId=12', 1, 14)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (29, N'You are candidate for captain', N'temp', 1, 1)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (30, N'You are candidate for captain', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (31, N'Please cast vote for class caption', N'Election/CastVote?electionId=13', 1, 9)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (32, N'Please cast vote for class caption', N'Election/CastVote?electionId=13', 1, 10)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (33, N'Please cast vote for class caption', N'Election/CastVote?electionId=13', 1, 11)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (34, N'You are candidate for class caption', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (35, N'You are candidate for class caption', N'temp', 1, 3)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (36, N'Please cast vote for test election', N'Election/CastVote?electionId=14', 1, 4)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (37, N'Please cast vote for test election', N'Election/CastVote?electionId=14', 1, 5)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (38, N'Please cast vote for test election', N'Election/CastVote?electionId=14', 1, 6)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (39, N'Please cast vote for test election', N'Election/CastVote?electionId=14', 1, 7)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (40, N'You are candidate for test election', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (41, N'You are candidate for test election', N'temp', 1, 3)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (42, N'Please cast vote for hero of lamar', N'Election/CastVote?electionId=15', 1, 5)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (43, N'Please cast vote for hero of lamar', N'Election/CastVote?electionId=15', 1, 6)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (44, N'Please cast vote for hero of lamar', N'Election/CastVote?electionId=15', 1, 7)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (45, N'Please cast vote for hero of lamar', N'Election/CastVote?electionId=15', 1, 12)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (46, N'You are candidate for hero of lamar', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (47, N'You are candidate for hero of lamar', N'temp', 1, 3)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (48, N'You are candidate for hero of lamar', N'temp', 1, 4)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (49, N'Please cast vote for finding the laziest person', N'Election/CastVote?electionId=16', 1, 4)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (50, N'Please cast vote for finding the laziest person', N'Election/CastVote?electionId=16', 1, 5)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (51, N'Please cast vote for finding the laziest person', N'Election/CastVote?electionId=16', 1, 7)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (52, N'Please cast vote for finding the laziest person', N'Election/CastVote?electionId=16', 1, 9)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (53, N'You are candidate for finding the laziest person', N'temp', 1, 1)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (54, N'You are candidate for finding the laziest person', N'temp', 1, 2)
INSERT [dbo].[Notification] ([notId], [message], [url], [unseen], [userId]) VALUES (55, N'You are candidate for finding the laziest person', N'temp', 1, 3)
SET IDENTITY_INSERT [dbo].[Notification] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [email], [password]) VALUES (1, N'basyal.suman866@gmail.com', N'suman')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (2, N'akash@gmail.com', N'akash')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (3, N'sulav@gmail.com', N'sulav')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (4, N'rajan@gmail.com', N'rajan')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (5, N'kausik@gmail.com', N'kausik')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (6, N'dolma@gmail.com', N'dolma')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (7, N'manisha@gmail.com', N'manisha')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (8, N'shreejan@gmail.com', N'shreejan')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (9, N'bishal@gmail.com', N'bishal')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (10, N'baldev@gmail.com', N'baldev')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (11, N'denish@gmail.com', N'denish')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (12, N'abhi@gmail.com', N'abhi')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (13, N'amar@gmail.com', N'amar')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (14, N'nabin@gmail.com', N'nabin')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (15, N'prabhakar@gmail.com', N'prabhakar')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (16, N'gaurab@gmail.com', N'gaurab')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (17, N'tara@gmail.com', N'tara')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (18, N'sushant@gmail.com', N'sushant')
INSERT [dbo].[User] ([userId], [email], [password]) VALUES (19, N'arbin@gmail.com', N'arbin')
SET IDENTITY_INSERT [dbo].[User] OFF
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (2, 11, 19, CAST(N'2018-02-28T03:38:52.923' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (3, 11, 19, CAST(N'2018-02-28T03:39:17.940' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (4, 11, 18, CAST(N'2018-02-28T03:39:43.627' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (4, 14, 2, CAST(N'2018-03-02T01:30:17.013' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (5, 11, 18, CAST(N'2018-02-28T03:41:58.673' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (5, 16, 2, CAST(N'2018-03-05T22:10:40.080' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (6, 15, 2, CAST(N'2018-03-05T21:14:39.240' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (7, 15, 4, CAST(N'2018-03-05T21:16:28.633' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (7, 16, 3, CAST(N'2018-03-05T21:38:21.530' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (9, 13, 2, CAST(N'2018-03-01T14:32:31.460' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (9, 13, 3, CAST(N'2018-03-01T14:32:28.903' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (10, 10, 3, CAST(N'2018-02-28T03:05:10.103' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (11, 10, 4, CAST(N'2018-02-28T02:59:24.727' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (12, 10, 2, CAST(N'2018-02-28T03:04:36.340' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (12, 12, 1, CAST(N'2018-02-28T03:47:20.033' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (12, 15, 2, CAST(N'2018-03-05T21:17:48.603' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (13, 10, 2, CAST(N'2018-02-28T03:04:00.490' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (13, 12, 1, CAST(N'2018-02-28T03:47:41.237' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (14, 10, 4, CAST(N'2018-02-28T03:02:47.887' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (14, 12, 2, CAST(N'2018-02-28T03:48:06.787' AS DateTime))
INSERT [dbo].[VoterElection] ([voterId], [electionId], [userId], [datetime]) VALUES (15, 10, 4, CAST(N'2018-02-28T03:03:29.477' AS DateTime))
SET ANSI_PADDING ON

GO
/****** Object:  Index [Uk_User_Email]    Script Date: 3/6/2018 1:54:59 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [Uk_User_Email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CandidateElection] ADD  CONSTRAINT [df_candidateelection_isapproved]  DEFAULT ((0)) FOR [isApproved]
GO
ALTER TABLE [dbo].[CandidateElection] ADD  CONSTRAINT [df_candidateelection_datetime]  DEFAULT (getdate()) FOR [datetime]
GO
ALTER TABLE [dbo].[CapableVoter] ADD  CONSTRAINT [df_requestelectionvote_datetime]  DEFAULT (getdate()) FOR [datetime]
GO
ALTER TABLE [dbo].[ElectionResult] ADD  CONSTRAINT [df_electionresult_datetime]  DEFAULT (getdate()) FOR [datetime]
GO
ALTER TABLE [dbo].[Notification] ADD  DEFAULT ((1)) FOR [unseen]
GO
ALTER TABLE [dbo].[VoterElection] ADD  CONSTRAINT [df_voterelection_datetime]  DEFAULT (getdate()) FOR [datetime]
GO
ALTER TABLE [dbo].[CandidateElection]  WITH CHECK ADD  CONSTRAINT [fk_candidateelection_electionid] FOREIGN KEY([electionId])
REFERENCES [dbo].[Election] ([electionId])
GO
ALTER TABLE [dbo].[CandidateElection] CHECK CONSTRAINT [fk_candidateelection_electionid]
GO
ALTER TABLE [dbo].[CandidateElection]  WITH CHECK ADD  CONSTRAINT [fk_candidateelection_userId] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[CandidateElection] CHECK CONSTRAINT [fk_candidateelection_userId]
GO
ALTER TABLE [dbo].[CapableVoter]  WITH CHECK ADD  CONSTRAINT [fk_RequestElectionVoter_electionid] FOREIGN KEY([electionId])
REFERENCES [dbo].[Election] ([electionId])
GO
ALTER TABLE [dbo].[CapableVoter] CHECK CONSTRAINT [fk_RequestElectionVoter_electionid]
GO
ALTER TABLE [dbo].[CapableVoter]  WITH CHECK ADD  CONSTRAINT [fk_RequestElectionVoter_userId] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[CapableVoter] CHECK CONSTRAINT [fk_RequestElectionVoter_userId]
GO
ALTER TABLE [dbo].[Election]  WITH CHECK ADD  CONSTRAINT [fk_election_adminId] FOREIGN KEY([adminId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[Election] CHECK CONSTRAINT [fk_election_adminId]
GO
ALTER TABLE [dbo].[ElectionResult]  WITH CHECK ADD  CONSTRAINT [fk_electionresult_electionId] FOREIGN KEY([electionId])
REFERENCES [dbo].[Election] ([electionId])
GO
ALTER TABLE [dbo].[ElectionResult] CHECK CONSTRAINT [fk_electionresult_electionId]
GO
ALTER TABLE [dbo].[ElectionResult]  WITH CHECK ADD  CONSTRAINT [fk_electionresult_winnerId] FOREIGN KEY([winnerId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[ElectionResult] CHECK CONSTRAINT [fk_electionresult_winnerId]
GO
ALTER TABLE [dbo].[Notification]  WITH CHECK ADD  CONSTRAINT [fk_notification_user] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[Notification] CHECK CONSTRAINT [fk_notification_user]
GO
ALTER TABLE [dbo].[VoterElection]  WITH CHECK ADD  CONSTRAINT [fk_voterelection_electionId] FOREIGN KEY([electionId])
REFERENCES [dbo].[Election] ([electionId])
GO
ALTER TABLE [dbo].[VoterElection] CHECK CONSTRAINT [fk_voterelection_electionId]
GO
ALTER TABLE [dbo].[VoterElection]  WITH CHECK ADD  CONSTRAINT [fk_voterelection_userId] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[VoterElection] CHECK CONSTRAINT [fk_voterelection_userId]
GO
ALTER TABLE [dbo].[VoterElection]  WITH CHECK ADD  CONSTRAINT [fk_voterelection_voterid] FOREIGN KEY([voterId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[VoterElection] CHECK CONSTRAINT [fk_voterelection_voterid]
GO
