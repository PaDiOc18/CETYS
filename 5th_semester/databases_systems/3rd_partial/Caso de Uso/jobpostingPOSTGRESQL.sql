create database jobposting;

create table account(
id_account int,
accountname varchar,
email varchar,
passwo varchar,
joindate date,
primary key(id_account)
);

create table employeeaccount(
title varchar,
status varchar,
skills varchar,
id_account int,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table employeraccount(
description varchar,
elocation varchar,
hiring bool,
id_account int,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table resume(
id_account int,
filepath varchar,
format varchar, 
uploaddate date,
FOREIGN KEY(id_account) REFERENCES account(id_account)	
);

create table topic(
id_topic int,
tname varchar,
description varchar,
primary key(id_topic)
);

create table post(
id_post int,
id_account int,
post_type int,
title varchar,
post_date date,
close_date date,
description varchar,
post_location varchar,
salary numeric(15,5),
id_topic int,
primary key(id_post),
FOREIGN KEY(id_account) REFERENCES account(id_account),
FOREIGN KEY(id_topic) REFERENCES topic(id_topic)
);

create table feed(
feed_name varchar,
description varchar,
keywords varchar
);