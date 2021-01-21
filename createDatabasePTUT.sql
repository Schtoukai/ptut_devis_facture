SET default_storage_engine= InnoDB;

drop database if exists invoiceDatabase;
create database invoiceDatabase;
use invoiceDatabase;

drop table if exists Remise;
drop table if exists Invoice;
drop table if exists Customer;
drop table if exists Materials;
drop table if exists Legislation;
drop table if exists Logo;
drop table if exists Company;

/*==============================================================*/
/* 						Table : Logo	                        */
/*==============================================================*/
create table Logo
(
	nameLogo						varchar(25),
    logoPath						varchar(25),
    formatLogo						varchar(3),
    primary key(nameLogo)
);
insert into Logo value("logo Entreprise","C:/aaa/AA/","png");

/*==============================================================*/
/* 						Table : Company                        */
/*==============================================================*/
create table Company
(
	siret						varchar(20),
    address						varchar(25),
    complement					varchar(25),
    zipcode						varchar(25),
    street						varchar(25),
    mail						varchar(25),
    phone						varchar(25),
    compLogo					varchar(25),
    primary key(siret),
constraint FK_ce_e foreign key (compLogo)
		references Logo (nameLogo) on delete restrict on update restrict
);
insert into Company value("27825665200010","address","complement","01000","BeB","mail@mail.com","0000000000","logo Entreprise");

/*==============================================================*/
/* 						Table : Legislation                     */
/*==============================================================*/
Create table Legislation
(
	typeLegislation				varchar(25),
    taux 		      			float,  
	primary key(typeLegislation)
);
INSERT into legislation values("type1",0.10),("type2",0.15),("type3",0.20);

/*==============================================================*/
/* 						Table : Materials                       */
/*==============================================================*/
Create table Materials
(
	idMaterials					int not null auto_increment,
    nameMaterials 				varchar(25),
    price 		      			float,  
    idLegislation				varchar(25),
	primary key(idMaterials),
	constraint FK_il_l foreign key (idLegislation)
		references Legislation (typeLegislation) on delete restrict on update restrict
);
INSERT INTO materials values('0','bois','50',"type2"),('0','acier','75',"type3"),('0','brique','80',"type1"),('0','AAA','50',"type2");

/*==============================================================*/
/* 						Table : Customer                        */
/*==============================================================*/
Create table Customer
(
	idCustomer						int not null auto_increment,
    nameCustomer 		      		varchar(100),  
    address							varchar(100),
		complement						varchar(100),
		zipCode							varchar(10),
		City							varchar(50),
    adresseMail						varchar(100),
    phone							varchar(8),
	primary key(idCustomer)
);
INSERT INTO Customer VALUES('0','Coulomb','la rue de jjjjj',null,'01000','Ville','aaa@gmail.com','0600000'),('0','AAA','4, rue liberte',null,'01000','Ville','AAA@gmail.com','0600000'),('0','BBB','4, rue liberte','complement','01000','Ville','BBB@gmail.com','0600000');
INSERT INTO Customer VALUES('0','CCC','4, rue liberte','complement','01000','Ville','CCC@gmail.com','0600000');
INSERT INTO Customer VALUES('0','DDD','4, rue liberte','complement','01000','Ville','DDD@gmail.com','0600000');
INSERT INTO Customer VALUES('0','EEE','4, rue liberte',null,'01000','Ville','EEE@gmail.com','0600000');
INSERT INTO Customer VALUES('0','FFF','4, rue liberte',null,'01000','Ville','FFF@gmail.com','0600000');
INSERT INTO Customer VALUES('0','GGG','4, rue liberte','complement','01000','Ville','GGG@gmail.com','0600000');
INSERT INTO Customer VALUES('0','HHH','4, rue liberte','complement','01000','Ville','HHH@gmail.com','0600000');
INSERT INTO Customer VALUES('0','III','4, rue liberte','complement','01000','Ville','III@gmail.com','0600000');
INSERT INTO Customer VALUES('0','JJJ','4, rue liberte',null,'01000','Ville','JJJ@gmail.com','0600000');
INSERT INTO Customer VALUES('0','KKK','4, rue liberte',null,'01000','Ville','KKK@gmail.com','0600000');
INSERT INTO Customer VALUES('0','LLL','4, rue liberte',null,'01000','Ville','LLL@gmail.com','0600000');

/*==============================================================*/
/* 						Table : Invoice                        	*/
/*==============================================================*/
Create table Invoice
(
	idInvoice						int not null auto_increment,
    dateCreation 		      		date,  
	Icustomer						int,
	primary key(idInvoice),
	constraint FK_invoice_customer foreign key (Icustomer)
		references Customer (idCustomer) on delete restrict on update restrict
);
INSERT INTO Invoice values('0','20211223','3');
INSERT INTO Invoice values("0",'20211223','5');
INSERT INTO Invoice values("0",'20211228',"1");
INSERT INTO Invoice values('0','20211225',"1");

select * from Invoice;

/*==============================================================*/
/* 						Table : Invoice_Material				*/
/*==============================================================*/
create table Invoice_Material
(
	idInvoice 						int,
    idMaterials						int,
    primary key(idInvoice,idMaterials),
    constraint FK_im_i foreign key (idInvoice)
		references Invoice (idInvoice) on delete restrict on update restrict,
	 constraint FK_im_m foreign key (idMaterials)
		references Materials (idMaterials) on delete restrict on update restrict
);
insert into Invoice_Material values(1,1),(1,2);

Select * from Invoice I join Invoice_Material IM on I.idInvoice = IM.idInvoice join Materials M on IM.idMaterials = IM.idMaterials join Legislation L on L.typeLegislation = M.idLegislation;
