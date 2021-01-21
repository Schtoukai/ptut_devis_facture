SET default_storage_engine= InnoDB;

drop database if exists invoiceDatabase;
create database invoiceDatabase;
use invoiceDatabase;

drop table if exists Remise;
drop table if exists invoice_customer;
drop table if exists Invoice;
drop table if exists Customer;
drop table if exists Materials;
drop table if exists Legislation;
drop table if exists Compagny;

/*==============================================================*/
/* 						Table : Logo	                        */
/*==============================================================*/
create table Logo
(
	nameLogo						varchar(25),
    formatLogo						varchar(25),
    height							varchar(25),
    width							varchar(25),
    pathing							varchar(25),
    primary key(nameLogo)
);


/*==============================================================*/
/* 						Table : Compagny                        */
/*==============================================================*/
create table Compagny
(
	siret						varchar(25),
    street						varchar(25),
    city						varchar(25),
    mail						varchar(25),
    phone						varchar(25),
    compLogo					varchar(25),
    primary key(siret),
constraint FK_ce_e foreign key (compLogo)
		references Logo (nameLogo) on delete restrict on update restrict
);


/*==============================================================*/
/* 						Table : Legislation                     */
/*==============================================================*/
Create table Legislation
(
	typeLegislation				varchar(25),
    taux 		      			float,  
	primary key(typeLegislation)
);

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

/*==============================================================*/
/* 						Table : Customer                        */
/*==============================================================*/
Create table Customer
(
	idCustomer						int not null auto_increment,
    nameCustomer 		      		varchar(100),  
    adresse							varchar(100),
    adresseMail						varchar(100),
    phone							varchar(8),
	primary key(idCustomer)
);

INSERT INTO Customer VALUES('0','Coulomb','la rue de jjjjj','aaa@gmail.com','0600000');
INSERT INTO Customer VALUES('0','AAA','4, rue liberte','AAA@gmail.com','0600000');
INSERT INTO Customer VALUES('0','BBB','4, rue liberte','BBB@gmail.com','0600000');
INSERT INTO Customer VALUES('0','CCC','4, rue liberte','CCC@gmail.com','0600000');
INSERT INTO Customer VALUES('0','DDD','4, rue liberte','DDD@gmail.com','0600000');
INSERT INTO Customer VALUES('0','EEE','4, rue liberte','EEE@gmail.com','0600000');
INSERT INTO Customer VALUES('0','FFF','4, rue liberte','FFF@gmail.com','0600000');
INSERT INTO Customer VALUES('0','GGG','4, rue liberte','GGG@gmail.com','0600000');
INSERT INTO Customer VALUES('0','HHH','4, rue liberte','HHH@gmail.com','0600000');
INSERT INTO Customer VALUES('0','III','4, rue liberte','III@gmail.com','0600000');
INSERT INTO Customer VALUES('0','JJJ','4, rue liberte','JJJ@gmail.com','0600000');
INSERT INTO Customer VALUES('0','KKK','4, rue liberte','KKK@gmail.com','0600000');
INSERT INTO Customer VALUES('0','LLL','4, rue liberte','LLL@gmail.com','0600000');


/*==============================================================*/
/* 						Table : Invoice                        	*/
/*==============================================================*/
Create table Invoice
(
	idInvoice						int not null auto_increment,
    dateCreation 		      		datetime,  

	primary key(idInvoice)
);

/*==============================================================*/
/* 					Table : invoice_customer          		   	*/
/*==============================================================*/
create table invoice_customer
(
	idInvoice 						int,
    idCustomer						int,
    primary key(idInvoice,idCustomer),
    constraint FK_ic_i foreign key (idInvoice)
		references Invoice (idInvoice) on delete restrict on update restrict,
	 constraint FK_ic_c foreign key (idCustomer)
		references Customer (idCustomer) on delete restrict on update restrict
);

/*==============================================================*/
/* 						Table : Remise             				*/
/*==============================================================*/
create table Remise
(
	idInvoice 						int,
    idMaterials						int,
    primary key(idInvoice,idMaterials),
    constraint FK_im_i foreign key (idInvoice)
		references Invoice (idInvoice) on delete restrict on update restrict,
	 constraint FK_im_m foreign key (idMaterials)
		references Materials (idMaterials) on delete restrict on update restrict
);

select * from Customer; 	
INSERT into legislation values("type1",0.10),("type2",0.15),("type3",0.20);
INSERT INTO materials values('0','bois','50',"type2"),('0','acier','75',"type3"),('0','brique','80',"type1"),('0','AAA','50',"type2");
select * from materials; 	