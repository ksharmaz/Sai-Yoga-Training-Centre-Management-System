Database Tables – Sai Yoga Training

-- ATTENDANCE TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Attendance]    Script Date: 3/26/2016 12:08:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Attendance](
	[sr_no] [int] IDENTITY(100,1) NOT NULL,
	[adate] [date] NOT NULL,
	[status] [varchar](255) NULL,
	[enroll_no] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sr_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
-- COURSE TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 3/26/2016 12:08:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Course](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [varchar](255) NOT NULL,
	[duration] [varchar](255) NOT NULL,
	[ctype] [varchar](255) NOT NULL,
	[benefits] [varchar](255) NULL,
	[fee] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
-- LOGIN TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 3/26/2016 12:09:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Login](
	[loginid] [int] IDENTITY(1000,1) NOT NULL,
	[userid] [varchar](255) NOT NULL,
	[passwd] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[loginid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [u_userid] UNIQUE NONCLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
-- PAYMENT TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Payment]    Script Date: 3/26/2016 12:09:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Payment](
	[pay_id] [int] IDENTITY(1,1) NOT NULL,
	[pay_amount] [int] NOT NULL,
	[balance] [int] NULL,
	[pay_date] [date] NOT NULL,
	[pay_type] [varchar](255) NULL,
	[other] [varchar](255) NULL,
	[enroll_no] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pay_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([enroll_no])
REFERENCES [dbo].[Trainee] ([enroll_no])
GO

ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_TraineeID_Payment] FOREIGN KEY([enroll_no])
REFERENCES [dbo].[Trainee] ([enroll_no])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_TraineeID_Payment]
GO
-- SALARY TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Salary]    Script Date: 3/26/2016 12:09:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Salary](
	[salary_no] [int] IDENTITY(1457,1) NOT NULL,
	[total_no_hrs] [int] NOT NULL,
	[charges_per_hrs] [int] NOT NULL,
	[total] [int] NOT NULL,
	[pay_date] [date] NOT NULL,
	[teacher_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[salary_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-- SCHEDULE TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Schedule]    Script Date: 3/26/2016 12:10:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Schedule](
	[schedule_id] [int] IDENTITY(1,1) NOT NULL,
	[class_date] [date] NULL,
	[class_time] [time](7) NULL,
	[teacher_id] [int] NULL,
	[course_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_CourseID_Schedule] FOREIGN KEY([course_id])
REFERENCES [dbo].[Course] ([course_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_CourseID_Schedule]
GO
-- SESSION TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Session]    Script Date: 3/26/2016 12:10:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Session](
	[sid] [int] IDENTITY(100,1) NOT NULL,
	[loginid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Session]  WITH CHECK ADD FOREIGN KEY([loginid])
REFERENCES [dbo].[Login] ([loginid])
GO
-- TEACHER TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Teacher]    Script Date: 3/26/2016 12:10:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Teacher](
	[teacher_id] [int] IDENTITY(1,1) NOT NULL,
	[tname] [varchar](255) NOT NULL,
	[taddress] [varchar](255) NOT NULL,
	[tphone] [varchar](12) NOT NULL,
	[tqualification] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[teacher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uk_tphone] UNIQUE NONCLUSTERED 
(
	[tphone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
-- TEACHER ATTENDANCE TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[TeacherAttendance]    Script Date: 3/26/2016 12:10:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TeacherAttendance](
	[sr_no] [int] IDENTITY(200,1) NOT NULL,
	[tadate] [date] NOT NULL,
	[status] [varchar](255) NOT NULL,
	[hrs_per_day] [int] NULL,
	[teacher_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sr_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TeacherAttendance]  WITH CHECK ADD FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
GO

ALTER TABLE [dbo].[TeacherAttendance]  WITH CHECK ADD  CONSTRAINT [FK_TeacherID_Attendance] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TeacherAttendance] CHECK CONSTRAINT [FK_TeacherID_Attendance]
GO
-- TRAINEE TABLE

USE [SaiYogaDB]
GO

/****** Object:  Table [dbo].[Trainee]    Script Date: 3/26/2016 12:11:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Trainee](
	[enroll_no] [int] IDENTITY(1,1) NOT NULL,
	[tname] [varchar](255) NOT NULL,
	[taddress] [varchar](255) NOT NULL,
	[contact] [varchar](255) NULL,
	[enroll_date] [datetime] NULL,
	[course_id] [int] NULL,
	[image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[enroll_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Trainee]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[Course] ([course_id])
GO

ALTER TABLE [dbo].[Trainee]  WITH CHECK ADD  CONSTRAINT [FK_CourseID] FOREIGN KEY([course_id])
REFERENCES [dbo].[Course] ([course_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Trainee] CHECK CONSTRAINT [FK_CourseID]
GO