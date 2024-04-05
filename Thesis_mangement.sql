--use master
--IF DB_ID('Thesis_management') IS NOT NULL
--BEGIN
--    DROP DATABASE Thesis_management
--END

--CREATE DATABASE Thesis_management
GO
USE Thesis_management
GO
CREATE TABLE Login (
	username nvarchar(20) PRIMARY KEY ,
	password_ nvarchar(20),
	role_  NVARCHAR(1) CHECK (role_ IN ('0', '1') ) not null
);
CREATE TABLE Teacher (
    teacher_id nvarchar(10) PRIMARY KEY ,
    name VARCHAR(100),
	email VARCHAR(100),
	username nvarchar(20)
	FOREIGN KEY (username) REFERENCES Login(username),
);

CREATE TABLE Student (
    student_id nvarchar(10) PRIMARY KEY ,
    name VARCHAR(100),
    email VARCHAR(100),
	username nvarchar(20),
    FOREIGN KEY (username) REFERENCES Login(username),

);

CREATE TABLE Category (
    category nvarchar(20) PRIMARY KEY ,
);
CREATE TABLE Thesis (
    thesis_id nvarchar(10) PRIMARY KEY ,
	topic nvarchar(100),
    teacher_id nvarchar(10),
	category nvarchar(20),
	Technology nvarchar(20),
	Number_member int,
	require text,
	Function_contain text,
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id),
	FOREIGN KEY (category) REFERENCES Category(category),
);

CREATE TABLE Thesis_register (
    thesis_id nvarchar(10),
    teacher_id nvarchar(10),
    student_id nvarchar(10),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id),
	FOREIGN KEY (student_id) REFERENCES Student(student_id),
	FOREIGN KEY (thesis_id) REFERENCES Thesis(thesis_id),
);
CREATE TABLE Thesis_info (
	Thesis_info int PRIMARY KEY IDENTITY(1, 1) ,
    thesis_id nvarchar(10),
    student_id nvarchar(10),
	FOREIGN KEY (student_id) REFERENCES Student(student_id),
	FOREIGN KEY (thesis_id) REFERENCES Thesis(thesis_id),
);
CREATE TABLE Meeting (
    meeting_id INT PRIMARY KEY IDENTITY(1, 1) ,
    student_id nvarchar(10),
	teacher_id nvarchar(10),
    date_time DATETIME,
    notification TEXT,
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id),
);

CREATE TABLE Evaluation (
    evaluation_id INT PRIMARY KEY ,
    thesis_id int,
    score DECIMAL(5, 2),
    feedback TEXT,
    FOREIGN KEY (thesis_id) REFERENCES Thesis_info(Thesis_info)
);
CREATE TABLE Task (
    task_id INT PRIMARY KEY IDENTITY(1, 1),
    Thesis_info INT,
    description TEXT,
    deadline DATE,
	status_  NVARCHAR(10) CHECK (status_ IN ('Incomplete', 'Complete') ) DEFAULT 'Incomplete',
    FOREIGN KEY (Thesis_info) REFERENCES Thesis_info(Thesis_info)
);