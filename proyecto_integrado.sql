CREATE DATABASE proyecto_integrado CHARACTER SET utf8;

USE proyecto_integrado;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `categoria` (`id_categoria`, `nombre`) VALUES
(1, 'Top'),
(2, 'Bottom'),
(3, 'Accesories'),
(4, 'Shoes');

CREATE TABLE `imagen` (
  `id_imagen` int(11) NOT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `imagenes` longblob NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `prenda` (
  `id_prenda` int(11) NOT NULL,
  `link` varchar(2000) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `id_imagen` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(25) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `foto_perfil` longblob,
  `contrasenya` varchar(19) NOT NULL,
  `biografia` varchar(100) DEFAULT NULL,
  `correo` varchar(45) NOT NULL,
  `pagina_web` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`);

ALTER TABLE `imagen`
  ADD PRIMARY KEY (`id_imagen`),
  ADD KEY `id_usuario` (`id_usuario`);

ALTER TABLE `prenda`
  ADD PRIMARY KEY (`id_prenda`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_imagen` (`id_imagen`);

ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);

ALTER TABLE `categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `imagen`
  MODIFY `id_imagen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

ALTER TABLE `prenda`
  MODIFY `id_prenda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

ALTER TABLE `imagen`
  ADD CONSTRAINT `imagen_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`);

ALTER TABLE `prenda`
  ADD CONSTRAINT `prenda_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`),
  ADD CONSTRAINT `prenda_ibfk_2` FOREIGN KEY (`id_imagen`) REFERENCES `imagen` (`id_imagen`);
