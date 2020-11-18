-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-11-2020 a las 00:36:30
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ratepi`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellidos` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`id`, `nombre`, `apellidos`, `email`) VALUES
(1, 'sdfsdf', 'sdfsdfsdfs', 'qweqweqe@sadhjfsdhjfsdf.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnosxproyectos`
--

CREATE TABLE `alumnosxproyectos` (
  `id` int(11) NOT NULL,
  `id_alumnos` int(11) NOT NULL,
  `id_proyectos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `alumnosxproyectos`
--

INSERT INTO `alumnosxproyectos` (`id`, `id_alumnos`, `id_proyectos`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistentes`
--

CREATE TABLE `asistentes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `apellidos` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `asistentes`
--

INSERT INTO `asistentes` (`id`, `nombre`, `apellidos`) VALUES
(1, 'LAMAMW', 'LALSDASda asudahuiduhia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistentesxcategoria`
--

CREATE TABLE `asistentesxcategoria` (
  `id` int(11) NOT NULL,
  `id_asistentes` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `voto` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `asistentesxcategoria`
--

INSERT INTO `asistentesxcategoria` (`id`, `id_asistentes`, `id_categoria`, `voto`) VALUES
(1, 1, 1, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre_categoria` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre_categoria`) VALUES
(1, 'categoria1'),
(2, 'categoria2'),
(3, 'categoria3');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectos`
--

CREATE TABLE `proyectos` (
  `id` int(11) NOT NULL,
  `ciclo_formativo` varchar(100) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `descripcion` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proyectos`
--

INSERT INTO `proyectos` (`id`, `ciclo_formativo`, `titulo`, `descripcion`) VALUES
(1, 'ciclo1', '213123123123', 'dadasdadasda'),
(2, 'ciclo2', 'adasdasds', 'asdsd1r312341324');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectosxcategoria`
--

CREATE TABLE `proyectosxcategoria` (
  `id` int(11) NOT NULL,
  `id_proyectos` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proyectosxcategoria`
--

INSERT INTO `proyectosxcategoria` (`id`, `id_proyectos`, `id_categoria`) VALUES
(1, 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `alumnosxproyectos`
--
ALTER TABLE `alumnosxproyectos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_alumnos` (`id_alumnos`),
  ADD KEY `id_proyectos` (`id_proyectos`);

--
-- Indices de la tabla `asistentes`
--
ALTER TABLE `asistentes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `asistentesxcategoria`
--
ALTER TABLE `asistentesxcategoria`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_asistentes` (`id_asistentes`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proyectosxcategoria`
--
ALTER TABLE `proyectosxcategoria`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_proyectos` (`id_proyectos`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `alumnosxproyectos`
--
ALTER TABLE `alumnosxproyectos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `asistentes`
--
ALTER TABLE `asistentes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `asistentesxcategoria`
--
ALTER TABLE `asistentesxcategoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proyectosxcategoria`
--
ALTER TABLE `proyectosxcategoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `alumnosxproyectos`
--
ALTER TABLE `alumnosxproyectos`
  ADD CONSTRAINT `alumnosxproyectos_ibfk_1` FOREIGN KEY (`id_proyectos`) REFERENCES `proyectos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `alumnosxproyectos_ibfk_2` FOREIGN KEY (`id_alumnos`) REFERENCES `alumnos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `asistentesxcategoria`
--
ALTER TABLE `asistentesxcategoria`
  ADD CONSTRAINT `asistentesxcategoria_ibfk_1` FOREIGN KEY (`id_asistentes`) REFERENCES `asistentes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `asistentesxcategoria_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `proyectosxcategoria` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `proyectosxcategoria`
--
ALTER TABLE `proyectosxcategoria`
  ADD CONSTRAINT `proyectosxcategoria_ibfk_1` FOREIGN KEY (`id_proyectos`) REFERENCES `proyectos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `proyectosxcategoria_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
