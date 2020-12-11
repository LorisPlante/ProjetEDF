-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 10 déc. 2020 à 22:52
-- Version du serveur :  10.4.14-MariaDB
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `edf`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `identifiant` int(11) NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `ancienReleve` int(11) NOT NULL,
  `dernierReleve` int(11) NOT NULL,
  `idcontroleur` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`identifiant`, `nom`, `prenom`, `ancienReleve`, `dernierReleve`, `idcontroleur`) VALUES
(1, 'De Nardi', 'Patrice', 1867, 2567, 1),
(2, 'Flipo', 'Mathieu', 3000, 4000, 1),
(3, 'Metzger', 'Corinne', 267, 789, 2),
(4, 'Kurschner', 'Thomas', 521, 846, 2),
(5, 'Dumay', 'Caroline', 1000, 1453, 3),
(6, 'Borrat', 'Thierry', 4000, 4892, 3),
(7, 'Jeanson', 'Virginie', 2001, 3000, 4),
(8, 'Combe', 'Jean-Pierre', 3000, 3500, 4),
(9, 'Mathieu', 'Royer', 0, 345, 6),
(10, 'Wiard', 'Sylvie', 0, 0, 7);

-- --------------------------------------------------------

--
-- Structure de la table `controleur`
--

CREATE TABLE `controleur` (
  `id` int(4) NOT NULL,
  `nom` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `prenom` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `login` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `mdp` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `statut` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `controleur`
--

INSERT INTO `controleur` (`id`, `nom`, `prenom`, `login`, `mdp`, `statut`) VALUES
(1, 'Girard', 'Michel', 'mg', 'mg123', 'admin'),
(2, 'Garnier', 'Francois', 'fg', 'fg123', 'ctrl'),
(3, 'Alison', 'Benjamin', 'ba', 'ba123', 'ctrl'),
(4, 'Gand', 'Christophe', 'cg', 'cg123', 'ctrl'),
(5, 'Fortin', 'François', 'ff', 'ff123', 'ctrl'),
(6, 'Test', 'Demo', 'td', 'td123', 'ctrl'),
(7, 'Cousinot', 'Sebastien', 'cs', 'cs123', 'ctrl');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`identifiant`),
  ADD KEY `idcontroleur` (`idcontroleur`);

--
-- Index pour la table `controleur`
--
ALTER TABLE `controleur`
  ADD PRIMARY KEY (`id`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`idcontroleur`) REFERENCES `controleur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
