-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2023 at 04:41 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `realestatec#project`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `CatID` int(11) NOT NULL,
  `Categories` varchar(100) NOT NULL,
  `TimeStamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`CatID`, `Categories`, `TimeStamp`) VALUES
(12, 'Foods', '2023-06-11 08:13:19'),
(13, 'Electricity', '2023-06-11 08:13:19'),
(15, 'Rent', '2023-06-11 08:13:19'),
(16, 'Groceries', '2023-06-11 08:13:19'),
(19, 'Travel', '2023-06-11 08:13:19'),
(21, 'Snacks1', '2023-06-11 09:52:47');

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

CREATE TABLE `expenses` (
  `ID` int(11) NOT NULL,
  `EXpenseAmount` int(10) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `CatID` int(10) NOT NULL,
  `SubCatID` int(10) NOT NULL,
  `TimeStamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `expenses`
--

INSERT INTO `expenses` (`ID`, `EXpenseAmount`, `Description`, `CatID`, `SubCatID`, `TimeStamp`) VALUES
(3, 50, 'Vegmeals', 2, 12, '2023-06-11 13:38:57'),
(4, 105, 'DDDSDS', 7, 16, '2023-06-11 14:14:13'),
(5, 450, 'dssffsd', 4, 12, '2023-06-11 13:54:56'),
(6, 855, 'ddsdsds7877', 6, 15, '2023-06-11 14:17:54');

-- --------------------------------------------------------

--
-- Table structure for table `subcategory`
--

CREATE TABLE `subcategory` (
  `SubCatID` int(11) NOT NULL,
  `SubCategory` varchar(50) NOT NULL,
  `CatID` int(11) NOT NULL,
  `TimeStamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subcategory`
--

INSERT INTO `subcategory` (`SubCatID`, `SubCategory`, `CatID`, `TimeStamp`) VALUES
(2, 'Lunch', 12, '2023-06-11 08:13:59'),
(3, 'Breakfast', 12, '2023-06-11 08:13:59'),
(4, 'Dinner', 12, '2023-06-11 08:13:59'),
(6, 'Old', 13, '2023-06-11 08:13:59'),
(7, 'Store', 15, '2023-06-11 08:13:59'),
(8, 'Evening1', 21, '2023-06-11 09:53:21');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `TimeStamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `ApproveUser` int(2) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `UserName`, `Password`, `TimeStamp`, `ApproveUser`) VALUES
(17, 'Admin', 'Admin', '2023-06-11 09:27:43', 1),
(23, 'ABDUL', 'ABDUL', '2023-06-11 11:01:38', 0),
(24, 'TestAdmin', 'TestAdmin', '2023-06-11 11:08:24', 1),
(25, 'TestAdmin', 'TestAdmin1', '2023-06-11 11:27:46', 1),
(26, 'Admin', 'Admin', '2023-06-11 11:47:44', 1),
(27, 'AdminTest', 'Admin', '2023-06-11 11:47:23', 1),
(28, 'AdminTest', 'Admin', '2023-06-11 11:46:49', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CatID`);

--
-- Indexes for table `expenses`
--
ALTER TABLE `expenses`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `subcategory`
--
ALTER TABLE `subcategory`
  ADD PRIMARY KEY (`SubCatID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `CatID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `expenses`
--
ALTER TABLE `expenses`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `subcategory`
--
ALTER TABLE `subcategory`
  MODIFY `SubCatID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
