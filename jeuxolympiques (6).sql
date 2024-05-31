-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 31 mai 2024 à 22:42
-- Version du serveur : 8.0.31
-- Version de PHP : 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `jeuxolympiques`
--

-- --------------------------------------------------------

--
-- Structure de la table `anneolympique`
--

DROP TABLE IF EXISTS `anneolympique`;
CREATE TABLE IF NOT EXISTS `anneolympique` (
  `id` varchar(50) NOT NULL,
  `annee` year DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `anneolympique`
--

INSERT INTO `anneolympique` (`id`, `annee`) VALUES
('2', 2028),
('1', 2024);

-- --------------------------------------------------------

--
-- Structure de la table `athlete`
--

DROP TABLE IF EXISTS `athlete`;
CREATE TABLE IF NOT EXISTS `athlete` (
  `id` int NOT NULL AUTO_INCREMENT,
  `prenom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `pays` varchar(50) DEFAULT NULL,
  `dateDeNaissance` date DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `sport` varchar(50) DEFAULT NULL,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `athlete`
--

INSERT INTO `athlete` (`id`, `prenom`, `pays`, `dateDeNaissance`, `genre`, `sport`, `nom`) VALUES
(33, 'Muhammad', 'États-Unis', '1942-01-17', 'Homme', 'Boxe', 'Ali'),
(32, 'Nadia', 'Roumanie', '1961-11-12', 'Femme', 'Gymnastique artistique', 'Comaneci'),
(31, 'Kohei', 'Japon', '1989-01-03', 'Homme', 'Gymnastique artistique', 'Uchimura'),
(30, 'Simone', 'États-Unis', '1997-03-14', 'Femme', 'Gymnastique artistique', 'Biles'),
(29, 'Caeleb', 'États-Unis', '1996-08-16', 'Homme', 'Natation', 'Dressel'),
(28, 'Katie', 'États-Unis', '1997-03-17', 'Femme', 'Natation', 'Ledecky'),
(27, 'Michael', 'États-Unis', '1985-06-30', 'Homme', 'Natation', 'Phelps'),
(26, 'Eliud', 'Kenya', '1984-11-05', 'Homme', 'Athlétisme', 'Kipchoge'),
(25, 'Allyson', 'États-Unis', '1985-11-18', 'Femme', 'Athlétisme', 'Felix'),
(24, 'Usain', 'Jamaïque', '1986-08-21', 'Homme', 'Athlétisme', 'Bolt'),
(22, 'salber', 'Allemagne', '1984-02-17', 'Homme', 'basketball', 'gaetan'),
(23, 'thomas', 'Algérie', '2024-02-29', 'Homme', 'escrime', 'sasa'),
(34, 'Claressa', 'États-Unis', '1995-03-17', 'Femme', 'Boxe', 'Shields'),
(35, 'Vasyl', 'Ukraine', '1988-02-17', 'Homme', 'Boxe', 'Lomachenko'),
(36, 'Lance', 'États-Unis', '1971-09-18', 'Homme', 'Cyclisme sur route', 'Armstrong'),
(37, 'Marianne', 'Pays-Bas', '1987-05-13', 'Femme', 'Cyclisme sur route', 'Vos'),
(38, 'Chris', 'Royaume-Uni', '1985-05-20', 'Homme', 'Cyclisme sur route', 'Froome'),
(39, 'Valentina', 'Italie', '1974-02-14', 'Femme', 'Escrime', 'Vezzali'),
(40, 'Aron', 'Hongrie', '1990-01-14', 'Homme', 'Escrime', 'Szilagyi'),
(41, 'Inna', 'Russie', '1990-03-11', 'Femme', 'Escrime', 'Deriglazova'),
(42, 'Lionel', 'Argentine', '1987-06-24', 'Homme', 'Football', 'Messi'),
(43, 'Marta', 'Brésil', '1986-02-19', 'Femme', 'Football', 'Vieira da Silva'),
(44, 'Cristiano', 'Portugal', '1985-02-05', 'Homme', 'Football', 'Ronaldo'),
(45, 'Teddy', 'France', '1989-04-07', 'Homme', 'Judo', 'Riner'),
(46, 'Ryoko', 'Japon', '1975-09-06', 'Femme', 'Judo', 'Tani'),
(47, 'Clarisse', 'France', '1992-10-25', 'Femme', 'Judo', 'Agbegnenou'),
(48, 'Aleksandr', 'Russie', '1967-09-19', 'Homme', 'Lutte', 'Karelin'),
(49, 'Saori', 'Japon', '1982-10-05', 'Femme', 'Lutte', 'Yoshida'),
(50, 'Jordan', 'États-Unis', '1988-07-08', 'Homme', 'Lutte', 'Burroughs'),
(51, 'Steve', 'Royaume-Uni', '1962-03-23', 'Homme', 'Aviron', 'Redgrave'),
(52, 'Georgeta', 'Roumanie', '1976-04-14', 'Femme', 'Aviron', 'Damian'),
(53, 'Mahe', 'Nouvelle-Zélande', '1978-11-19', 'Homme', 'Aviron', 'Drysdale'),
(54, 'Kim', 'Corée du Sud', '1992-06-20', 'Homme', 'Tir à l\'arc', 'Woo-jin'),
(55, 'Brady', 'États-Unis', '1988-10-27', 'Homme', 'Tir à l\'arc', 'Ellison'),
(56, 'Ki', 'Corée du Sud', '1988-02-20', 'Femme', 'Tir à l\'arc', 'Bo-bae'),
(57, 'test', 'Portugal', '2003-02-05', 'Homme', 'football', 'test');

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

DROP TABLE IF EXISTS `evenement`;
CREATE TABLE IF NOT EXISTS `evenement` (
  `id` int NOT NULL AUTO_INCREMENT,
  `disciplinne` varchar(50) DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `idAnneOlympique` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAnneOlympique` (`idAnneOlympique`)
) ENGINE=MyISAM AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `evenement`
--

INSERT INTO `evenement` (`id`, `disciplinne`, `genre`, `idAnneOlympique`) VALUES
(10, 'Athlétisme', 'Homme', '1'),
(8, 'football', 'Homme', '1'),
(11, 'Athlétisme', 'Femme', '1'),
(5, 'bowling', 'Homme', '2'),
(7, 'tennis', 'Homme', '2'),
(12, 'Natation', 'Homme', '1'),
(13, 'Natation', 'Femme', '1'),
(14, 'Gymnastique artistique', 'Homme', '1'),
(15, 'Gymnastique artistique', 'Femme', '1'),
(16, 'Boxe', 'Homme', '1'),
(17, 'Boxe', 'Femme', '1'),
(18, 'Cyclisme sur route', 'Homme', '1'),
(19, 'Cyclisme sur route', 'Femme', '1'),
(20, 'Escrime', 'Homme', '1'),
(21, 'Escrime', 'Femme', '1'),
(22, 'Football', 'Homme', '1'),
(23, 'Football', 'Femme', '1'),
(24, 'Judo', 'Homme', '1'),
(25, 'Judo', 'Femme', '1'),
(26, 'Lutte', 'Homme', '1'),
(27, 'Lutte', 'Femme', '1'),
(28, 'Aviron', 'Homme', '1'),
(29, 'Aviron', 'Femme', '1'),
(30, 'Tir à l\'arc', 'Homme', '1'),
(31, 'Tir à l\'arc', 'Femme', '1'),
(32, 'Plongeon', 'Homme', '1'),
(33, 'Plongeon', 'Femme', '1'),
(34, 'Équitation', 'Homme', '1'),
(35, 'Équitation', 'Femme', '1'),
(36, 'Handball', 'Homme', '1'),
(37, 'Handball', 'Femme', '1'),
(38, 'Hockey sur gazon', 'Homme', '1'),
(39, 'Hockey sur gazon', 'Femme', '1'),
(40, 'Tennis', 'Homme', '1'),
(41, 'Tennis', 'Femme', '1'),
(42, 'Tennis de table', 'Homme', '1'),
(43, 'Tennis de table', 'Femme', '1'),
(44, 'Volley-ball', 'Homme', '1'),
(45, 'Volley-ball', 'Femme', '1'),
(46, 'Skateboard', 'Homme', '1'),
(47, 'Skateboard', 'Femme', '1'),
(48, 'Surf', 'Homme', '1'),
(49, 'Surf', 'Femme', '1'),
(50, 'Escalade', 'Homme', '1'),
(51, 'Escalade', 'Femme', '1'),
(52, 'Breaking', 'Homme', '1'),
(53, 'Breaking', 'Femme', '1');

-- --------------------------------------------------------

--
-- Structure de la table `medaille`
--

DROP TABLE IF EXISTS `medaille`;
CREATE TABLE IF NOT EXISTS `medaille` (
  `id` int NOT NULL AUTO_INCREMENT,
  `typeMedaille` varchar(50) DEFAULT NULL,
  `idAthlete` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAthlete` (`idAthlete`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medaille`
--

INSERT INTO `medaille` (`id`, `typeMedaille`, `idAthlete`) VALUES
(1, 'médaille d\'or', '22'),
(4, 'médaille d\'or', '23'),
(3, 'médaille d\'argent', '2');

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

DROP TABLE IF EXISTS `participer`;
CREATE TABLE IF NOT EXISTS `participer` (
  `idAthlete` varchar(50) NOT NULL,
  `idEvenement` varchar(50) NOT NULL,
  PRIMARY KEY (`idAthlete`,`idEvenement`),
  KEY `idEvenement` (`idEvenement`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `participer`
--

INSERT INTO `participer` (`idAthlete`, `idEvenement`) VALUES
('29', '8'),
('44', '24');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
