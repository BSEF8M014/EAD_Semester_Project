-- Create Database job_portal;
Create Table users(
	user_id int primary key IDENTITY(1,1),
	user_name varchar(45) unique not null, 
	user_pass varchar(45) not null,
	user_type int
	);
Create Table Addresses(
	Address_id int primary key identity(1,1),
	house_no int,
	street_no int,
	town varchar(45),
	city varchar(70),
	country varchar(30)
	);
Create Table Job_Resume(
	Job_Resume_id int primary key identity(1,1)
	);
Create Table Education(
	Education_id int primary key identity(1,1),
	Job_Resume_id int foreign key References Job_Resume(Job_Resume_id),
	Qualification varchar(45)
	);
Create Table Experience(
	Experience_id int primary key identity(1,1),
	Job_Resume_id int foreign key References Job_Resume(Job_Resume_id),
	Descriptions varchar(45)
	);
Create Table seeker(
	user_id int FOREIGN KEY REFERENCES users(user_id),
	seeker_id int primary key IDENTITY(1,1),
	Address_id int foreign key references Addresses(Address_id),
	first_name varchar(45),
	last_name varchar(45),
	father_name varchar(45),
	Job_Resume_id int foreign key References Job_Resume(Job_Resume_id)
	);
Create Table company(
	user_id int FOREIGN KEY REFERENCES users(user_id),
	company_id int primary key identity(1,1),
	company_name varchar(45),
	);
Create Table Job(
	Job_id int primary key IDENTITY(1,1),
	company_id int FOREIGN KEY REFERENCES company(company_id),
	Job_tilte varchar(40),
	Job_Desc varchar(100)
	);
Create Table Job_Application(
	Job_Application_id int primary key IDENTITY(1,1),
	seeker_id int FOREIGN KEY REFERENCES seeker(seeker_id),
	job_id int FOREIGN KEY REFERENCES job(job_id),
	Date_time DateTime
	);