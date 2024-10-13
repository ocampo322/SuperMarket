
use Supermarket;

create table Customer (
    Customer_Id INT PRIMARY KEY,
    Customer_Document_Number CHAR(15) NOT NULL UNIQUE,
    Customer_First_Name CHAR(50) NOT NULL,
    Customer_Last_Name CHAR(50) NOT NULL,
    Customer_Address VARCHAR(80),
    Customer_Birthday DATETIME,
    Customer_Phone_Number CHAR(16),
    Customer_Email VARCHAR(100)
)