drop table batch;
drop table trainers;
drop table associates;
create table associates
(
	id int identity primary key,
	associateName nvarchar(100) not null,
	associateLocation varchar(2) not null,
	revaPoints int not null
);
create table trainers
(
	id int identity primary key,
	trainerName varchar(20) not null,
	campus varchar(3) not null,
	caffeineLevel int not null
);
create table batch
(
	id int identity primary key,
	associateID int references associates(id),
	trainerID int references trainers (id)
);
insert into associates (associateName, associateLocation, revaPoints) values
('Joaquin', 'PA', -10), ('Madeline', 'WA', 10), ('Jacob', 'FL', 0), ('Michael', 'AZ', 20), ('Janel', 'AZ', 50), ('Angeleen', 'TX', 30), ('Warren', 'TS', 40);
insert into trainers (trainerName, campus, caffeineLevel) values
('Marielle', 'USF', 5), ('Pushpinder', 'UTA', 50), ('Nick', 'UTA', 75), ('Mark', 'WVU', 16), ('Fred', 'UTA', 25);
insert into batch (associateID, trainerID) values
(3,3), (1,1), (2,1), (4,1), (6,1), (7,1);

select * from associates;
select * from trainers;

--insert 5 associates into associates
insert into associates (associateName, associateLocation, revaPoints) values ('Jacob', 'KS', 15), ('David', 'AZ', 10), ('Hans', 'FL', 20), ('Weston', 'WA', 30), ('Bob', 'SC', 0);

--associates that live in AZ
select * from associates where associateLocation = 'AZ';

--order by associate location
select * from associates order by associateLocation asc;

--count each locations associate
select associateLocation, count(associateLocation) from associates group by associateLocation order by associateLocation asc;

--get trainers without associates using subqueries
select trainerName from trainers where id not in (select trainerID from batch);
--get trainers without associates using joins
select trainerName from trainers left outer join batch on trainers.id = batch.trainerID where batch.trainerID is null;

--get associates mapped to a trainer using subqueries
select associateName from associates where id in (select associateID from batch);
--get associates mapped to a trainer using joins
select associateName from associates left outer join batch on associates.id = batch.associateID where batch.associateID is not null;

--get associates without a trainer using subqueries
select associateName from associates where id not in (select associateID from batch);
--get associates without a trainer using joins
select associateName from associates left outer join batch on associates.id = batch.associateID where batch.associateID is null;