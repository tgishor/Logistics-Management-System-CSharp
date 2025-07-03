use E_ShiftSystem

-- Customer --
CREATE TABLE customer (
c_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
c_name VARCHAR(50) NOT NULL,
c_nic VARCHAR(12) NOT NULL,
c_address VARCHAR(100) NOT NULL,
c_phoneNo NUMERIC(10) NOT NULL
);

-- Transport Unit --

CREATE TABLE container (
con_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
con_name VARCHAR(30) NOT NULL
);

CREATE TABLE lorryType(
lorryType_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
lorryType VARCHAR(10) NOT NULL
);

CREATE TABLE lorry(
lorry_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
lorry_number VARCHAR(30) NOT NULL,
lorryType_id_fk INT NOT NULL,
CONSTRAINT FK1 FOREIGN KEY (lorryType_id_fk) REFERENCES lorryType(lorryType_id)
);

CREATE TABLE assistant(
ass_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ass_name VARCHAR(50) NOT NULL,
ass_nic VARCHAR(12) NOT NULL,
ass_phoneNo NUMERIC(10) NOT NULL
);

CREATE TABLE driver(
dri_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
dri_name VARCHAR(50) NOT NULL,
dri_licenseNo VARCHAR(20) NOT NULL,
dri_phoneNo NUMERIC(10) NOT NULL
);


CREATE TABLE transportUnit(
tu_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
dri_id_fk INT NOT NULL,
ass_id_fk INT NOT NULL,
con_id_fk INT NOT NULL,
lorry_id_fk INT NOT NULL,
CONSTRAINT FK2 FOREIGN KEY (dri_id_fk) REFERENCES driver(dri_id),
CONSTRAINT FK3 FOREIGN KEY (ass_id_fk) REFERENCES assistant(ass_id),
CONSTRAINT FK4 FOREIGN KEY (con_id_fk) REFERENCES container(con_id),
CONSTRAINT FK5 FOREIGN KEY (lorry_id_fk) REFERENCES lorry(lorry_id)
);

-- Goods --
CREATE TABLE goodType(
goodType_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
goodType VARCHAR(30) NOT NULL
);


CREATE TABLE good(
good_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
good_name VARCHAR(50) NOT NULL,
good_desc VARCHAR(100) NOT NULL,
goodType_id_fk INT NOT NULL,
CONSTRAINT FK6 FOREIGN KEY (goodType_id_fk) REFERENCES goodType(goodType_id)
);

-- Payment --
CREATE TABLE paymentType(
pType_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
pType VARCHAR(50) NOT NULL
);

CREATE TABLE payment(
p_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
p_amount NUMERIC(10) NOT NULL,
p_date DATETIME NOT NULL,
pType_id_fk INT NOT NULL,
CONSTRAINT FK7 FOREIGN KEY (pType_id_fk) REFERENCES paymentType(pType_id)
);

-- Job --

CREATE TABLE jobStatus(
jStatus_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
jStatus VARCHAR(30) NOT NULL
);

CREATE TABLE job(
j_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
j_regDateTime DATETIME NOT NULL,
j_pickLocation VARCHAR(100) NOT NULL,
j_pickDateTime DATETIME NOT NULL,
c_id_fk INT NOT NULL,
tu_id_fk INT NOT NULL,
CONSTRAINT FK8 FOREIGN KEY (c_id_fk) REFERENCES customer(c_id)
);

ALTER TABLE job ADD good_id_fk INT NOT NULL, CONSTRAINT FK17 FOREIGN KEY (good_id_fk) REFERENCES good(good_id), CONSTRAINT FK18 FOREIGN KEY (tu_id_fk) REFERENCES transportUnit(tu_id)

SELECT * FROM job

ALTER TABLE job DROP COLUMN good_id_fk 

ALTER TABLE job ADD CONSTRAINT defaultTrackingStatus
DEFAULT '6' FOR tracking_id_fk; 

SELECT * FROM trackStatus

SELECT * FROM jobStatus
-- Load --
CREATE TABLE load(
l_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
quantity NUMERIC(10) NOT NULL,
j_id_fk INT NOT NULL,
good_id_fk INT NOT NULL,
CONSTRAINT FK9 FOREIGN KEY (j_id_fk) REFERENCES job(j_id),
CONSTRAINT FK10 FOREIGN KEY (good_id_fk) REFERENCES good(good_id)
);

CREATE TABLE city(
city_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
city_name VARCHAR(30) NOT NULL
);

DROP TABLE city



ALTER TABLE customer ADD city_id_fk INT NOT NULL, CONSTRAINT FK11 FOREIGN KEY (city_id_fk) REFERENCES city(city_id)

INSERT INTO city VALUES ('batticaloa')

SELECT * FROM city

DELETE FROM city WHERE city_id = 2

INSERT INTO city VALUES ('Batticaloa');
INSERT INTO city VALUES ('Colombo');
INSERT INTO city VALUES ('Gampaha')
INSERT INTO city VALUES ('Kalutara');
INSERT INTO city VALUES ('Kandy');
INSERT INTO city VALUES ('Matale');
INSERT INTO city VALUES ('Nuwara Eliya');
INSERT INTO city VALUES ('Galle');
INSERT INTO city VALUES ('Matara')
INSERT INTO city VALUES ('Hambantota');
INSERT INTO city VALUES ('Jaffna');
INSERT INTO city VALUES ('Kilinochchi');
INSERT INTO city VALUES ('Mannar');
INSERT INTO city VALUES ('Vavuniya');
INSERT INTO city VALUES ('Mullaitivu');
INSERT INTO city VALUES ('Ampara');
INSERT INTO city VALUES ('Trincomalee');
INSERT INTO city VALUES ('Kurunegala');
INSERT INTO city VALUES ('Puttalam');
INSERT INTO city VALUES ('Anuradhapura');
INSERT INTO city VALUES ('Polonnaruwa');
INSERT INTO city VALUES ('Badulla');
INSERT INTO city VALUES ('Moneragala');
INSERT INTO city VALUES ('Ratnapura');
INSERT INTO city VALUES ('Kegalle');


SELECT * FROM customer 
SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id

SELECT * FROM assistant


CREATE TABLE gender (
gender_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
gender_name VARCHAR(7) NOT NULL 
);

ALTER TABLE driver ADD dri_nic VARCHAR(20) ,gender_id_fk INT NOT NULL,  CONSTRAINT FK13 FOREIGN KEY (gender_id_fk) REFERENCES gender(gender_id)


SELECT * FROM driver

ALTER TABLE lorry DROP COLUMN lorry_name
ALTER TABLE lorry ADD lorry_name VARCHAR(50) NOT NULL

SELECT * FROM Lorry



INSERT INTO lorryType (lorryType_name) VALUES ('Buddy');


SELECT * FROM lorryType
SELECT * FROM lorry
DELETE FROM lorryType WHERE lorryType_id = 4



SELECT * FROM transportUnit

ALTER TABLE transportUnit ADD tu_desc VARCHAR(255) NOT NULL 

SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS ' Unit Description',
driver.dri_name AS 'Driver Name',
driver.dri_phoneNo AS 'Driver Phone',
assistant.ass_name AS 'Assistant Name',
assistant.ass_phoneNo AS 'Assistant Phone',
container.con_id AS 'Container Name',
lorry.lorry_name AS 'Lorry Name',
lorry.lorry_number AS 'Lorry Name'
FROM transportUnit 


INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id
INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id
INNER JOIN container ON transportUnit.con_id_fk = container.con_id
INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id


SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS ' Unit Description', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_id AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Name' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id 


SELECT * FROM transportUnit


"INSERT INTO transportUnit (tu_desc, dri_id_fk, ass_id_fk, con_id_fk, lorry_id_fk) VALUES ('asdadsawsaw', '1','1','System.Data.DataRowView', '1') "


SELECT * FROM goodType

SELECT * FROM good


ALTER TABLE good ADD good_initailAmount NUMERIC(10) NOT NULL

ALTER TABLE good DROP COLUMN good_desc

SELECT good.good_id AS 'Good ID', good.good_name AS 'Good Name', good.good_initailAmount AS 'Good Initial Amount', goodType.goodType AS 'Good Type'  FROM good INNER JOIN goodType ON good.goodType_id_fk = goodType.goodType_id;
 
INSERT INTO goodType VALUES ('Fragile Good');
INSERT INTO goodType VALUES ('General Good');
INSERT INTO goodType VALUES ('Valueable Good');
INSERT INTO goodType VALUES ('Hazardous Good');

INSERT INTO good (good_name, good_initailAmount, goodType_id_fk) VALUES ('sdawsaw', '12', '2')

SELECT * FROM job

SELECT * FROM transportUnit

SELECT * FROM jobStatus

INSERT INTO jobStatus VALUES ('Accepted');
INSERT INTO jobStatus VALUES ('Waiting For Approval');

CREATE TABLE trackStatus(
track_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
trackingProccess VARCHAR(50) NOT NULL 
);


INSERT INTO trackStatus VALUES ('Reaching the Pickup Location');
INSERT INTO trackStatus VALUES ('Loading Goods At Pickup Location');
INSERT INTO trackStatus VALUES ('Unloading the Good at Destination');
INSERT INTO trackStatus VALUES ('Job Completed');
INSERT INTO trackStatus VALUES ('Job Cancelled');
INSERT INTO trackStatus VALUES ('Job in Waiting');


SELECT * FROM trackStatus

ALTER TABLE job ADD tracking_id_fk INT NOT NULL,jobStatus_id_fk INT NOT NULL , CONSTRAINT FK15 FOREIGN KEY (tracking_id_fk) REFERENCES trackStatus(track_id), CONSTRAINT FK16 FOREIGN KEY (jobStatus_id_fk) REFERENCES jobStatus(jStatus_id)

SELECT * FROM job


ALTER TABLE job ADD j_dropLocation VARCHAR(255) NOT NULL

SELECT SCOPE_IDENTITY()

SELECT @@IDENTITY

SELECT * FROM customer

SELECT SCOPE_IDENTITY() AS lastInsertedID

SELECT * FROM job

DELETE FROM job WHERE j_id  = 3

INSERT INTO job (j_regDateTime, j_pickLocation, j_pickDateTime, j_dropLocation, c_id_fk, tu_id_fk,jobStatus_id_fk) VALUES ('10-Jul-22 6:27:52 PM','66/5, Old Kalmunai Road, Kallady Uppodai, Batticaloa', '10/07/2022 04:30:41 PM','New Dutchbar Road, Kallady, Batticaloa', '8','6','3'); SELECT SCOPE_IDENTITY() AS lastInsertedID



ALTER TABLE job ADD j_payable NUMERIC(20) NOT NULL

SELECT * FROM load

DELETE FROM customer WHERE c_id BETWEEN 1 AND 23; 

SELECT load.l_id AS 'Load ID', good.good_name 'Good Name', load.quantity 'Goods Quantity' FROM load INNER JOIN good ON load.good_id_fk = good.good_id;

SELECT * FROM load INNER JOIN job ON load.j_id_fk = job.j_id INNER JOIN good ON load.good_id_fk = good.good_id WHERE job.j_id = 6;

SELECT * FROM payment WHERE p_id = 6



INSERT INTO paymentType VALUES ('Card Payment')


SELECT * FROM payment 

ALTER TABLE payment ADD j_id_fk INT NOT NULL, CONSTRAINT FK20 FOREIGN KEY (j_id_fk) REFERENCES job(j_id)

SELECT * FROM paymentType


DELETE FROM payment 
SELECT p_id AS 'Payment ID', p_date AS 'Payment Date', p_amount AS 'Payment Amount', paymentType.pType AS 'Payment Type', customer.c_name AS 'Customer Name', customer.c_phoneNo AS 'Customer Phone' FROM payment 
INNER JOIN job ON payment.j_id_fk = job.j_id 
INNER JOIN customer ON job.c_id_fk = customer.c_id
INNER JOIN paymentType ON payment.pType_id_fk = paymentType.pType_id

SELECT * FROM job

SELECT * FROM payment

UPDATE payment SET pType_id_fk = 2 WHERE p_id = 1;

SELECT * FROM job

SELECT IDENT_CURRENT('job')

SELECT job.j_regDateTime AS 'Reg TimeStamp', 
job.j_pickLocation AS 'Pickup Location', 
job.j_dropLocation AS 'Drop Location', 
job.j_pickDateTime AS 'Drop Location', 
customer.c_name AS 'Cus Name', 
customer.c_phoneNo AS 'Cus Phone', 
jobStatus.jStatus AS 'Job Status', 
trackStatus.trackingProccess AS 'Tracking Status'
FROM job 
INNER JOIN customer ON job.c_id_fk = customer.c_id
INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id
INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id;


SELECT job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id;

SELECT * FROM trackStatus

SELECT * FROM customer

DELETE FROM job WHERE j_id BETWEEN 7 AND 16

SELECT * FROM job

CREATE 




CREATE TABLE admin(
adm_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
adm_name  VARCHAR(60) NOT NULL,
adm_email VARCHAR(80) NOT NULL,
adm_username VARCHAR(80) NOT NULL,
adm_password VARCHAR(100) NOT NULL
);

SELECT * FROM customer

ALTER TABLE customer ADD c_email VARCHAR(60), c_username VARCHAR(60), c_password VARCHAR(60) 


SELECT adm_id AS 'Admin ID', adm_name AS 'Admin Name', adm_email AS 'Admin Email', adm_username AS 'Username', adm_password AS 'Password' FROM admin

INSERT INTO admin (adm_name, adm_email, adm_username, adm_password) VALUES ();


UPDATE admin SET adm_name ='"+ +"' , adm_email ='"+ +"' , adm_username ='"+ +"' , adm_password ='"+ +"' WHERE adm_id = 


SELECT * FROM admin WHERE adm_username = 'GishorAdmin'


SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE jobStatus.jStatus = 'Waiting For Approval';

SELECT * FROM trackStatus

-- Query For Job on Service in Dashboard
SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job 
INNER JOIN customer ON job.c_id_fk = customer.c_id  
INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id 
INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE trackStatus.trackingProccess <> 'Job in Waiting' AND trackStatus.trackingProccess <> 'Job Completed'

SELECT * FROM payment

UPDATE payment SET j_id_fk = 4  WHERE p_id = 1

-- Query For Chart Total Revenue in Dashboard

SELECT p_amount,j_id_fk FROM payment
SELECT * FROM payment
SELECT sum(p_amount) FROM payment WHERE p_date BETWEEN '2022-07-01 00:00:00:00' AND '2022-07-31 00:00:00:00' GROUP BY p_date;

SELECT * FROM payment 

DELETE FROM payment WHERE p_id = 6

SELECT p_amount,j_id_fk, p_date FROM payment

SELECT job.j_id AS 'Job ID', 
job.j_regDateTime AS 'Reg TimeStamp', 
job.j_pickLocation AS 'Pickup Location', 
job.j_dropLocation AS 'Drop Location', 
job.j_pickDateTime AS 'Drop Location', 
customer.c_name AS 'Cus Name', 
customer.c_phoneNo AS 'Cus Phone', 
jobStatus.jStatus AS 'Job Status', 
trackStatus.trackingProccess AS 'Tracking Status',
transportUnit.tu_id AS 'Transport Unit ID' 
FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  
INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id 
INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id
INNER JOIN transportUnit ON job.tu_id_fk = transportUnit.tu_id
WHERE trackStatus.trackingProccess = 'Job Completed' OR trackStatus.trackingProccess = 'Job Cancelled' OR trackStatus.trackingProccess = 'Job in Waiting'


SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE trackStatus.trackingProccess != 'Job in Waiting' AND trackStatus.trackingProccess != 'Job Completed' AND trackStatus.trackingProccess != 'Job Cancelled'


SELECT * FROM transportUnit

SELECT * FROM trackStatus v4  Job in Waiting

Job ID


trackingProccess
Reaching the Pickup Location

track_id
1


CREATE TABLE tu_status(
tu_status_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
tu_statusName VARCHAR(60) NOT NULL
);

INSERT INTO tu_status VALUES ('Available');
INSERT INTO tu_status VALUES ('Not Available');

SELECT * FROM tu_status

ALTER TABLE transportUnit ADD tu_status_fk INT , CONSTRAINT FK21 FOREIGN KEY (tu_status_fk) REFERENCES tu_status(tu_status_id)

ALTER TABLE transportUnit ADD DEFAULT '1' FOR tu_status_fk

select * from transportUnit

UPDATE transportUnit SET tu_status_fk = 2 WHERE tu_id = 6

SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status', transportUnit.tu_id AS 'Transport Unit ID' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id INNER JOIN transportUnit ON job.tu_id_fk = transportUnit.tu_id WHERE trackStatus.trackingProccess = 'Job Completed' OR trackStatus.trackingProccess = 'Job Cancelled' OR trackStatus.trackingProccess = 'Job in Waiting'


SELECT * FROM transportUnit INNER JOIN tu_status ON transportUnit.tu_status_fk = tu_status.tu_status_id WHERE tu_status.tu_statusName = 'Available'

SELECT * from payment

SELECT sum(p_amount) AS 'Amount' , CAST(p_date AS DATE) AS 'Date' FROM payment GROUP BY CAST(p_date AS DATE)



SELECT * FROM trackStatus

DELETE FROM customer WHERE c_id = 25
DELETE FROM job WHERE c_id_fk BETWEEN 27 AND 44

c_name, c_nic, c_address, c_phoneNo, city_id_fk, c_email	

SELECT * FROM load

SELECT l_id AS 'Load ID', j_id_fk AS 'Job ID', good.good_name AS 'Good Name', load.quantity AS 'Goods Quantity'  FROM load INNER JOIN good ON load.good_id_fk = good.good_id


SELECT * FROM load

INSERT INTO load (quantity, j_id_fk, good_id_fk) VALUES ()








