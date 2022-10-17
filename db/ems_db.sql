-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2022 at 08:56 AM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `assetregister`
--

CREATE TABLE `assetregister` (
  `assid` int(11) NOT NULL,
  `ecnum` varchar(255) NOT NULL,
  `seria` varchar(255) NOT NULL,
  `model` varchar(255) NOT NULL,
  `dob` varchar(255) NOT NULL,
  `sp` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assetregister`
--

INSERT INTO `assetregister` (`assid`, `ecnum`, `seria`, `model`, `dob`, `sp`) VALUES
(1, 'kuda', 'NJBDS892W', 'TP Link', '', 64555),
(2, 'judah', 'HJBAS672', '24 Port Switch', '', 64649),
(3, 'mario', 'NMZDXUWOQ966', 'HP DJ Printer', '', 48526),
(4, 'jordan', '354WKJASD25', 'Wall Driller', '', 65468),
(5, 'palmer', 'DSF6452', 'Laptop Fan', '', 8888),
(6, 'striker', 'KJHDSIW0934084', 'Seagate External Hard Drive', '', 5000),
(7, 'cream', 'SXCSXNCNKJ3726', 'Television Screen', '', 4520),
(9, 'mhanza', 'ER12J921JK', 'BMW M3', '', 213412);

-- --------------------------------------------------------

--
-- Table structure for table `confisticated`
--

CREATE TABLE `confisticated` (
  `Confisticat_Id` int(11) NOT NULL,
  `Serial_Number` varchar(255) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `Date_Purchsed` varchar(255) NOT NULL,
  `Stock_Price` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `confisticated`
--

INSERT INTO `confisticated` (`Confisticat_Id`, `Serial_Number`, `Model`, `Date_Purchsed`, `Stock_Price`) VALUES
(1, 'CNU1382iuohjio', 'mac book pro', '', 12450),
(3, 'CNU1323232323', 'asus', '', 8764),
(4, 'CNU666j47', 'Samsung', '', 500),
(5, 'FBC874004X5', 'Lenovo IBM Thinkpad', '', 3164),
(6, 'VN78H61', 'Trsla Model 3', '2022-10-17', 45332);

-- --------------------------------------------------------

--
-- Table structure for table `library`
--

CREATE TABLE `library` (
  `Library_Id` int(11) NOT NULL,
  `Name` char(255) NOT NULL,
  `Asset_Borrowed` varchar(255) NOT NULL,
  `Serial_Number` varchar(255) NOT NULL,
  `Due_Date` varchar(255) NOT NULL,
  `Phone` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `library`
--

INSERT INTO `library` (`Library_Id`, `Name`, `Asset_Borrowed`, `Serial_Number`, `Due_Date`, `Phone`) VALUES
(10, 'benji', 'TV stand', '7862187u09ujn', '', 2017),
(27, 'cghvghv', 'ghvgv', 'r55r65', '6767686', 56464);

-- --------------------------------------------------------

--
-- Table structure for table `maintain`
--

CREATE TABLE `maintain` (
  `Main_Id` int(11) NOT NULL,
  `Owner` varchar(255) NOT NULL,
  `Serial_Number` varchar(255) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `History` varchar(255) NOT NULL,
  `Repair_Cost` int(255) NOT NULL,
  `Repaired By` char(255) NOT NULL,
  `Fixed_On` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `maintain`
--

INSERT INTO `maintain` (`Main_Id`, `Owner`, `Serial_Number`, `Model`, `History`, `Repair_Cost`, `Repaired By`, `Fixed_On`) VALUES
(2, 'garry', '64:64:87:89:kk:jf', 'hp envy', 'Needed new O.S', 4, 'Kuda', '2017-03-11'),
(3, 'ethan', '64:64:87:89:kk:jf', 'hp envy', 'Required more RAM', 40, 'Morris', '2018-03-06'),
(4, 'braun', '64:64:87:89:kk:jf', 'hp envy', 'Replace damaged Screen', 400, 'Kuda', '2019-03-26'),
(5, 'brayy', '6p:64:ff:f3:09', 'HP 4530S', 'Broken NIC', 64, 'Jay You', '2020-03-30'),
(6, 'enzo', '6p:64:ff:f3:09', 'HP 4530S', 'Trojan Virus Attack', 1, 'Yadish Da Chronic', '2020-04-04'),
(7, 'dobbadon', '6p:64:ff:f3:09', 'HP 4530S', 'Replace Dead USB port', 50, 'Tino', '2020-04-30'),
(10, 'zhara', '84:46:kj:po:4l:k4:00', 'samsung', 'Replaced laptop stands', 33, 'Bhiyadho', '2017-03-10'),
(11, 'mhiko', '84:46:kj:po:4l:k4:00', 'Samsung', 'Needed new O.S', 4, 'Chris', '2017-01-08'),
(12, 'rwizi', '6p:64:ff:f3:09', 'HP 4530S', 'required driver pack', 97, 'Murkowski', '2021-01-01'),
(13, 'stuart', '97:AT:83:5G:PP:00:0A', 'Mac book lite', 'Replaced dead power button', 90, 'Jimmy', '2019-12-11'),
(14, 'progress', '97:AT:83:5G:PP:00:0A', 'Mac book lite', 'update driver pack', 1, 'Wyteboi', '2020-01-16'),
(15, 'sam', '97:AT:83:5G:PP:00:0A', 'Mac book lite', 'Faaulty keyboard', 50, 'Kuda', '2020-03-04'),
(16, 'jim', '97:AT:83:5G:PP:00:0A', 'Mac book lite', 'Ransomware Attack', 34, 'Jay You', '2020-02-29'),
(17, 'noah', '97:AT:83:5G:PP:00:0A', 'Mac book lite', 'Needed new O.S', 1, 'Siziba', '2020-03-17'),
(18, 'matt', '89:32:LK:JS:AD', 'Toshiba', 'Required new Hard Drive ', 450, 'Merinda', '2020-02-04'),
(19, 'bktherula', 'KJ:09;8K:J7:55:43:HG', 'Mac book lite', 'Broken fan', 120, 'Kuda', '2017-03-02'),
(20, 'since99', 'KJ:09;8K:J7:55:43:HG', 'Mac book lite', 'Broken NIC', 120, 'Trymore', '2018-02-07'),
(21, 'gamu', '02:78:TH:9d:Y8:AA', 'IBM', 'Needed new paint job', 6, 'Hwinza', '2017-10-10'),
(22, 'neria', '33:87:fg:4f:a4:00:9a', 'Dell', 'Blue screen of death', 2, 'Major', '2020-03-31'),
(23, 'shumba', '97:f7:ff:f3:91', 'HP spectra', 'Debloting', 50, 'Morris', '2020-02-05'),
(24, 'goerge', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Trojan Virus Attack', 87, 'Green', '2022-05-28'),
(25, 'benji', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Damaged Screen', 615, 'Kuda', '2023-01-09'),
(26, 'bootleg', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Debloting', 5, 'Yellow', '2024-07-25'),
(27, 'kuda', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Broken fan', 11, 'Jay You', '2025-01-03'),
(28, 'chido', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Needed more RAM', 22, 'zero', '2025-01-23'),
(29, 'ze0018', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Blue screen of death', 878, 'Uno', '2025-02-08'),
(30, 'ze0018', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Trojan Virus Attack', 50, 'Virgil', '2025-03-09'),
(31, 'ze0018', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Faaulty keyboard', 44, 'Hwinza', '2025-03-30'),
(32, 'ze0018', '87:FG:97:D5:6S', 'Sun MicroSystems', 'Replace Dead USB port', 97, 'Serere', '2025-03-31'),
(33, 'ze0018', '87:FG:97:D5:6S', 'Sun MicroSystems', 'required cleaning', 1, 'Kuda', '2025-04-01'),
(34, 'ze0019', '13:14:1L:16:L0', 'HP 4530S', 'Ransomware Attack', 54, 'Jay You', '2019-12-05');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `username`, `password`) VALUES
(1, 'Kuda Rukuni', 'krukuni@gmail.com', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assetregister`
--
ALTER TABLE `assetregister`
  ADD PRIMARY KEY (`assid`);

--
-- Indexes for table `confisticated`
--
ALTER TABLE `confisticated`
  ADD PRIMARY KEY (`Confisticat_Id`);

--
-- Indexes for table `library`
--
ALTER TABLE `library`
  ADD PRIMARY KEY (`Library_Id`);

--
-- Indexes for table `maintain`
--
ALTER TABLE `maintain`
  ADD PRIMARY KEY (`Main_Id`) USING BTREE;

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assetregister`
--
ALTER TABLE `assetregister`
  MODIFY `assid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `confisticated`
--
ALTER TABLE `confisticated`
  MODIFY `Confisticat_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `library`
--
ALTER TABLE `library`
  MODIFY `Library_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `maintain`
--
ALTER TABLE `maintain`
  MODIFY `Main_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
