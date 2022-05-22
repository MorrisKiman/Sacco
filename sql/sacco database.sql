-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 17, 2022 at 09:15 PM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: sacco
--

create database sacco;
use sacco;

-- --------------------------------------------------------

--
-- Table structure for table accname
--

DROP TABLE IF EXISTS accname;
CREATE TABLE IF NOT EXISTS accname (
  AccName varchar(100) DEFAULT NULL,
  Name_ID int(2) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (Name_ID)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table accname
--

INSERT INTO accname (AccName, Name_ID) VALUES
('Deposit Account', 1),
('Shares Account', 2),
('Withdrawable Deposit', 3);

-- --------------------------------------------------------

--
-- Table structure for table attendant
--

DROP TABLE IF EXISTS attendant;
CREATE TABLE IF NOT EXISTS attendant (
  AttendantID int(40) NOT NULL AUTO_INCREMENT,
  AttendantFname varchar(100) DEFAULT NULL,
  AttendantLname varchar(100) DEFAULT NULL,
  AttendantPass varchar(100) DEFAULT NULL,
  Contacts varchar(50) DEFAULT NULL,
  PRIMARY KEY (AttendantID)
) ENGINE=MyISAM AUTO_INCREMENT=100117 DEFAULT CHARSET=latin1;

--
-- Dumping data for table attendant
--

INSERT INTO attendant (AttendantID, AttendantFname, AttendantLname, AttendantPass, Contacts) VALUES
(1109, 'Ismael', 'Bukina', 'ismael', '087987978798'),
(1110, 'Anne', 'Songari', 'annsonga', '09089498878'),
(1111, 'Andrew', 'Odera', 'admin', '0789654332'),
(100116, 'root', 'root', 'morris', '078894566');

-- --------------------------------------------------------

--
-- Table structure for table boss
--

DROP TABLE IF EXISTS boss;
CREATE TABLE IF NOT EXISTS boss (
  UserName varchar(20) NOT NULL,
  Fname varchar(40) DEFAULT NULL,
  Password varchar(100) DEFAULT NULL,
  PRIMARY KEY (UserName)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table boss
--

INSERT INTO boss (UserName, Fname, Password) VALUES
('Admin', 'admin', '12345'),
('Morris', 'Morris', 'Kimani'),
('root', 'root', 'morris');

-- --------------------------------------------------------

--
-- Table structure for table loans
--

DROP TABLE IF EXISTS loans;
CREATE TABLE IF NOT EXISTS loans (
  LoanID int(40) NOT NULL AUTO_INCREMENT,
  Loan_Type varchar(40) DEFAULT NULL,
  LoanReason varchar(200) DEFAULT NULL,
  LoanAmount double(10,2) DEFAULT NULL,
  Load_StartD date NOT NULL,
  Load_EndD date NOT NULL,
  MemberID int(40) NOT NULL,
  TellerID int(40) NOT NULL,
  payable decimal(10,2) NOT NULL,
  paid decimal(10,2) DEFAULT NULL,
  status varchar(40) NOT NULL,
  PRIMARY KEY (LoanID)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Dumping data for table loans
--

INSERT INTO loans (LoanID, Loan_Type, LoanReason, LoanAmount, Load_StartD, Load_EndD, MemberID, TellerID, payable, paid, status) VALUES
(1, 'Emmergency', 'Fire brokeout.', 10000.00, '2018-04-01', '2018-04-15', 22, 10023, '0.00', '0.00', ''),
(2, 'Emmergency', 'fireee', 7800.00, '2018-04-01', '2018-04-01', 22, 10024, '0.00', '0.00', ' unpaid '),
(3, 'School Fees', 'dfdfvsdvsd', 1000.00, '2018-04-01', '2018-04-01', 22, 10024, '0.00', '0.00', ' unpaid '),
(4, 'Business', 'cvdfvd', 112.00, '2018-04-01', '2018-04-01', 22, 10024, '119.00', '101.00', ' unpaid '),
(5, 'Business', 'tgrtg', 10.00, '2018-04-01', '2018-04-01', 22, 10024, '11.00', '0.00', 'Complete'),
(6, 'Emmergency', 'Stock was stolen', 10000.00, '2018-04-03', '2018-04-03', 27, 10025, '10591.34', '0.00', ' unpaid '),
(7, 'School Fees', 'Fees for my children', 2000.00, '2018-04-03', '2018-04-03', 22, 10025, '2118.27', '0.00', 'Complete'),
(8, 'Emmergency', 'Buy new phone', 10000.00, '2018-04-03', '2018-04-03', 28, 10025, '10591.34', '0.00', ' unpaid '),
(9, 'School Fees', 'fees', 12000.00, '2018-04-04', '2018-04-04', 24, 10025, '12709.61', '0.00', ' unpaid '),
(10, 'Emmergency', 'reason', 1000.00, '2018-04-04', '2018-04-04', 25, 10024, '1059.13', '0.00', ' unpaid '),
(11, 'Business', 'Add stock', 10000.00, '2018-04-05', '2018-04-05', 30, 10025, '10591.34', '2000.00', ' unpaid '),
(12, 'Emmergency', 'restore damaged wall', 10000.00, '2018-04-15', '2018-04-15', 23, 10025, '10591.34', '0.00', ' unpaid '),
(13, 'Business', 'Add stock', 5000.00, '2019-01-22', '2019-01-22', 31, 10024, '5295.67', '3000.00', ' unpaid ');

-- --------------------------------------------------------

--
-- Table structure for table loantype
--

DROP TABLE IF EXISTS loantype;
CREATE TABLE IF NOT EXISTS loantype (
  typeID int(2) NOT NULL AUTO_INCREMENT,
  typeName varchar(100) NOT NULL,
  PRIMARY KEY (typeID)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table loantype
--

INSERT INTO loantype (typeID, typeName) VALUES
(1, 'Emmergency'),
(2, 'Business'),
(3, 'School Fees');

-- --------------------------------------------------------

--
-- Table structure for table members
--

DROP TABLE IF EXISTS members;
CREATE TABLE IF NOT EXISTS members (
  MemberID int(40) NOT NULL AUTO_INCREMENT,
  Fname varchar(40) DEFAULT NULL,
  Lname varchar(40) DEFAULT NULL,
  IDno varchar(40) DEFAULT NULL,
  Contacts varchar(40) DEFAULT NULL,
  DOB date NOT NULL,
  DOE datetime NOT NULL,
  Occupation varchar(40) DEFAULT NULL,
  Residence varchar(40) DEFAULT NULL,
  BeneficiaryName varchar(40) DEFAULT NULL,
  BeneficiarySname varchar(40) DEFAULT NULL,
  BeneficiaryID varchar(40) DEFAULT NULL,
  BeneficiaryContacts varchar(40) DEFAULT NULL,
  PRIMARY KEY (MemberID)
) ENGINE=MyISAM AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;

--
-- Dumping data for table members
--

INSERT INTO members (MemberID, Fname, Lname, IDno, Contacts, DOB, DOE, Occupation, Residence, BeneficiaryName, BeneficiarySname, BeneficiaryID, BeneficiaryContacts) VALUES
(28, 'Madonna', 'Benson', '986859', '07234567', '1996-05-20', '2018-04-03 11:29:06', 'IT Consultant', 'Kileleshwa', 'Morris', 'Kimani', '8976778', '7897656778'),
(26, 'Denlitah', 'Achieng', '234540', '078900876', '1980-10-21', '2018-04-03 10:27:59', 'Teacher', 'Embakasi', 'Edna', 'Otunga', '8787899', '0766865420'),
(27, 'Boniface', 'Kyalo', '89009876', '0721678907', '1988-08-08', '2018-04-03 10:29:42', 'Teacher', 'Thika', 'Wambui', 'Kyalo', '900023', '075645567'),
(25, 'Dennis', 'Rikobe', '389288', '0723456787', '1969-01-05', '2018-04-03 10:26:15', 'Taxi Driver', 'Ruai', 'Anne', 'Kiguta', '8987687', '076657534');

-- --------------------------------------------------------

--
-- Table structure for table messages
--

DROP TABLE IF EXISTS messages;
CREATE TABLE IF NOT EXISTS messages (
  msg_id int(11) NOT NULL AUTO_INCREMENT,
  msg_title varchar(100) DEFAULT NULL,
  msg_content varchar(2000) NOT NULL,
  msg_status varchar(1) DEFAULT '0',
  msa_response varchar(2000) DEFAULT NULL,
  mag_sender varchar(11) DEFAULT NULL,
  msg_recepient varchar(11) DEFAULT NULL,
  PRIMARY KEY (msg_id)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table savings
--

DROP TABLE IF EXISTS savings;
CREATE TABLE IF NOT EXISTS savings (
  AccountID int(40) NOT NULL AUTO_INCREMENT,
  AccountName varchar(40) DEFAULT NULL,
  Account_Value decimal(10,0) DEFAULT NULL,
  MemberID int(40) NOT NULL,
  Date_created date NOT NULL,
  Date_Deposited date NOT NULL,
  PRIMARY KEY (AccountID)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

--
-- Dumping data for table savings
--

INSERT INTO savings (AccountID, AccountName, Account_Value, MemberID, Date_created, Date_Deposited) VALUES
(11, 'Deposit Account', '212000', 22, '2018-03-29', '2018-04-02'),
(12, 'Deposit Account', '5000', 27, '2018-04-03', '2018-04-03'),
(13, 'Deposit Account', '5000', 26, '2018-04-03', '2018-04-03'),
(14, 'Shares Account', '12000', 23, '2018-04-03', '2018-08-03'),
(15, 'Withdrawable Deposit', '19000', 22, '2018-04-03', '2018-04-04'),
(16, 'Withdrawable Deposit', '4000', 27, '2018-04-03', '2018-04-03'),
(17, 'Withdrawable Deposit', '20000', 24, '2018-04-03', '2018-04-03'),
(18, 'Shares Account', '34790', 24, '2018-04-03', '2019-01-22'),
(19, 'Shares Account', '120500', 24, '2018-04-03', '2018-08-03'),
(20, 'Deposit Account', '50020', 28, '2018-04-03', '2018-04-07'),
(21, 'Deposit Account', '5000', 29, '2018-04-03', '2018-04-03'),
(22, 'Withdrawable Deposit', '38000', 25, '2018-04-03', '2018-04-03'),
(23, 'Shares Account', '11000', 30, '2018-04-05', '2018-04-05'),
(24, 'Withdrawable Deposit', '234560', 23, '2019-01-21', '2019-01-21'),
(25, 'Deposit Account', '10000', 31, '2019-01-22', '2019-01-22');

-- --------------------------------------------------------

--
-- Table structure for table teller
--

DROP TABLE IF EXISTS teller;
CREATE TABLE IF NOT EXISTS teller (
  TellerID int(40) NOT NULL AUTO_INCREMENT,
  Teller_Fname varchar(100) DEFAULT NULL,
  Teller_Sname varchar(100) DEFAULT NULL,
  TellerPass varchar(100) DEFAULT NULL,
  Contacts varchar(100) DEFAULT NULL,
  PRIMARY KEY (TellerID)
) ENGINE=MyISAM AUTO_INCREMENT=100117 DEFAULT CHARSET=latin1;

--
-- Dumping data for table teller
--

INSERT INTO teller (TellerID, Teller_Fname, Teller_Sname, TellerPass, Contacts) VALUES
(10023, 'Nimaki', 'Nagasaki', 'Nagasaki', '08797665'),
(10024, 'Andrew', 'Fartward', 'sidcom', '273568347'),
(10025, 'Andrea', 'Nelson', 'Nellidrea', '1382938729'),
(10026, 'Recheal', 'Wangari', '7438478', '799765878'),
(11111, 'Adrew', 'Odera', 'admin', '0987654323'),
(100116, 'root', 'root', 'morris', '078894566');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
