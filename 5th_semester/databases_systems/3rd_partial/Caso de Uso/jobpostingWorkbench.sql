create database jobposting;
use jobposting;

create table account(
id_account int,
accountname varchar(50),
email varchar(50),
passwo varchar(50),
joindate date,
primary key(id_account)
);

create table employeeaccount(
title varchar(50),
status varchar(50),
skills varchar(50),
id_account int,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table employeraccount(
description varchar(50),
elocation varchar(50),
hiring bool,
id_account int,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table resume(
id_account int,
filepath varchar(50),
format varchar(50), 
uploaddate date,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table topic(
id_topic int,
tname varchar(50),
description varchar(50),
primary key(id_topic)
);

create table post(
id_post int,
id_account int,
post_type int,
title varchar(50),
post_date date,
close_date date,
description varchar(50),
post_location varchar(50),
salary numeric(15,5),
id_topic int,
primary key(id_post),
FOREIGN KEY(id_account) REFERENCES account(id_account),
FOREIGN KEY(id_topic) REFERENCES topic(id_topic)
);

create table feed(
feed_name varchar(50),
description varchar(50),
keywords varchar(50)
);