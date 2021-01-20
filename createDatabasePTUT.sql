SET default_storage_engine= InnoDB;

drop database if exists invoiceDatabase;
create database invoiceDatabase;
use invoiceDatabase;

drop table if exists Remise;
drop table if exists invoice_customer;
drop table if exists invoice_legislation;
drop table if exists Invoice;
drop table if exists Customer;
drop table if exists Legislation;
drop table if exists Materials;



/*==============================================================*/
/* 						Table : Materials                       */
/*==============================================================*/

Create table Materials
(
	idMaterials					int not null auto_increment,
    nameMaterials 				varchar(25),
    price 		      			float,  
	primary key(idMaterials)
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

INSERT INTO Customer VALUES('0','Coulomb','4, rue liberte','aa@gmail.com','06456780');


/*==============================================================*/
/* 						Table : Invoice                        */
/*==============================================================*/

Create table Invoice
(
	idInvoice						int not null auto_increment,
    dateCreation 		      		datetime,  

	primary key(idInvoice)
);

/*==============================================================*/
/* 						Table : invoice_legislation             */
/*==============================================================*/

create table invoice_legislation
(
	idInvoice 						int,
    typeLegislation					varchar(25),
    primary key(idInvoice,typeLegislation),
    constraint FK_il_i foreign key (idInvoice)
		references Invoice (idInvoice) on delete restrict on update restrict,
	 constraint FK_il_l foreign key (typeLegislation)
		references Legislation (typeLegislation) on delete restrict on update restrict
);

/*==============================================================*/
/* 						Table : invoice_customer             	*/
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
/* 						Table : Remise             	*/
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



