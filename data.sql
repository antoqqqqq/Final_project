USE Thesis_management;

-- Insert data into Login table
INSERT INTO Login (username, password_, role_)
VALUES
    ('teacher1', 'teacher1pass', '0'),
    ('teacher2', 'teacher2pass', '0'),
    ('teacher3', 'teacher3pass', '0'),
    ('teacher4', 'teacher4pass', '0'),
    ('teacher5', 'teacher5pass', '0'),
    ('student1', 'student1pass', '1'),
    ('student2', 'student2pass', '1'),
    ('student3', 'student3pass', '1'),
    ('student4', 'student4pass', '1'),
    ('student5', 'student5pass', '1');

-- Insert data into Teacher table
INSERT INTO Teacher (teacher_id, name, email, username)
VALUES
    ('T1', N'Nguyễn Văn A', 'teacher1@example.com', 'teacher1'),
    ('T2', N'Phạm Thị B', 'teacher2@example.com', 'teacher2'),
    ('T3', N'Trần Văn C', 'teacher3@example.com', 'teacher3'),
    ('T4', N'Lê Thị D', 'teacher4@example.com', 'teacher4'),
    ('T5', N'Huỳnh Văn E', 'teacher5@example.com', 'teacher5');

-- Insert data into Student table
INSERT INTO Student (student_id, name, email, username)
VALUES
    ('S1', N'Trần Thị Hằng', 'student1@example.com', 'student1'),
    ('S2', N'Nguyễn Văn Nam', 'student2@example.com', 'student2'),
    ('S3', N'Hoàng Thị Lan', 'student3@example.com', 'student3'),
    ('S4', N'Phạm Minh Tuấn', 'student4@example.com', 'student4'),
    ('S5', N'Lê Thị Hương', 'student5@example.com', 'student5');

-- Insert data into Category table
INSERT INTO Category (category)
VALUES
    ('Computer Science'),
    ('Mathematics'),
    ('Physics'),
    ('Chemistry'),
    ('Biology'),
    ('Engineering'),
    ('Psychology'),
    ('Sociology'),
    ('History'),
    ('Literature');

-- Insert data into Thesis table

INSERT INTO Thesis (thesis_id, topic, teacher_id, category, Technology, Number_member, require, Function_contain)
VALUES
    ('TH1', N'Development of a web-based learning platform', 'T1', 'Computer Science', 'HTML, CSS, JavaScript', 5, N'Experience in web development', N'Interactive learning features'),
    ('TH2', N'Analysis of algorithms for optimization problems', 'T2', 'Mathematics', 'Algorithm analysis', 4, N'Mathematical modeling skills', N'Algorithm efficiency analysis'),
    ('TH3', N'Exploration of quantum entanglement', 'T3', 'Physics', 'Quantum mechanics', 6, N'Understanding of quantum theory', N'Experimental setup and analysis'),
    ('TH4', N'Investigation of chemical reactions at nanoscale', 'T4', 'Chemistry', 'Nanotechnology', 7, N'Laboratory experience in chemistry', N'Nanoparticle synthesis and characterization'),
    ('TH5', N'Study of genetic variation in populations', 'T5', 'Biology', 'Genetics', 5, N'Understanding of genetics principles', N'Population genetics analysis'),
    -- Add more sample data for theses as needed
    ('TH6', N'Design and development of autonomous robots', 'T1', 'Engineering', 'Robotics, Artificial Intelligence', 4, N'Robotics and AI knowledge', N'Robot navigation and control algorithms'),
    ('TH7', N'Investigation of cognitive processes in decision-making', 'T2', 'Psychology', 'Cognitive psychology, Neuroscience', 6, N'Understanding of cognitive science', N'Neuroimaging data analysis'),
    ('TH8', N'Study of social networks and their impact on society', 'T3', 'Sociology', 'Social network analysis', 5, N'Sociological research skills', N'Social network data collection and analysis'),
    ('TH9', N'Analysis of historical events in the context of globalization', 'T4', 'History', 'Global history', 7, N'Historical research skills', N'Globalization impact analysis'),
    ('TH10', N'Exploration of literary themes in contemporary literature', 'T5', 'Literature', 'Literary analysis', 5, N'Literary analysis skills', N'Contemporary literature review and analysis'),
    ('TH11', N'Development of efficient algorithms for data compression', 'T1', 'Computer Science', 'Data compression', 4, N'Algorithm design skills', N'Data compression algorithms development'),
    ('TH12', N'Study of number theory and its applications in cryptography', 'T2', 'Mathematics', 'Number theory, Cryptography', 6, N'Mathematical theory understanding', N'Cryptography algorithms development'),
    ('TH13', N'Investigation of dark matter and dark energy in the universe', 'T3', 'Physics', 'Astrophysics', 5, N'Understanding of astrophysical concepts', N'Observational data analysis'),
    ('TH14', N'Analysis of environmental impacts of industrial pollution', 'T4', 'Chemistry', 'Environmental chemistry', 7, N'Environmental science knowledge', N'Pollution monitoring and analysis')