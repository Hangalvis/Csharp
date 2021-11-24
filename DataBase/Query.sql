Create table Teacher(
id int identity primary key,
name varchar(100)
);

create table Course(
id int identity primary key,
name varchar(100),
id_teacher int ,
CONSTRAINT fk_Teeachr FOREIGN KEY (id_teacher)
REFERENCES Teacher(id)
);