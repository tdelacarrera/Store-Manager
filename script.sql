SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `tkg` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci ;
USE `tkg` ;

CREATE TABLE IF NOT EXISTS `tkg`.`User_type` (
  `id_user_type` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(45) NULL,
  `state` VARCHAR(45) NULL,
  PRIMARY KEY (`id_user_type`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`User` (
  `id_user` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `rut` VARCHAR(45) NULL,
  `username` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  `state` INT NULL,
  `User_type_id_user_type` INT NOT NULL,
  PRIMARY KEY (`id_user`),
  CONSTRAINT `fk_User_User_type1`
    FOREIGN KEY (`User_type_id_user_type`)
    REFERENCES `tkg`.`User_type` (`id_user_type`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`Audit` (
  `id_audit` INT NOT NULL AUTO_INCREMENT,
  `date` DATE NULL,
  `hour` TIME NULL,
  `action` VARCHAR(255) NULL,
  PRIMARY KEY (`id_audit`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`Purchase` (
  `id_purchase` INT NOT NULL AUTO_INCREMENT,
  `number` INT NULL,
  `date` DATE NULL,
  `hour` TIME NULL,
  `User_id_user` INT NULL,
  `User_user_type_id_user_type` INT NULL,
  PRIMARY KEY (`id_purchase`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`Product_family` (
  `id_product_family` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `state` INT NULL,
  PRIMARY KEY (`id_product_family`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`Product` (
  `id_product` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `price` INT NULL,
  `stock` INT NULL,
  `state` INT NULL,
  `Product_family_id_product_family` INT NOT NULL,
  PRIMARY KEY (`id_product`),
  CONSTRAINT `fk_Product_Product_family`
    FOREIGN KEY (`Product_family_id_product_family`)
    REFERENCES `tkg`.`Product_family` (`id_product_family`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `tkg`.`Product_has_Purchase` (
  `Product_id_product` INT NOT NULL,
  `Purchase_id_purchase` INT NOT NULL,
  PRIMARY KEY (`Product_id_product`, `Purchase_id_purchase`),
  CONSTRAINT `fk_Product_has_Purchase_Product1`
    FOREIGN KEY (`Product_id_product`)
    REFERENCES `tkg`.`Product` (`id_product`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Product_has_Purchase_Purchase1`
    FOREIGN KEY (`Purchase_id_purchase`)
    REFERENCES `tkg`.`Purchase` (`id_purchase`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO `user_type` (`id_user_type`, `description`, `state`) VALUES ('1', 'Administrador', 'Activo'), ('2', 'Bodeguero', 'Activo'), ('3', 'Usuario', 'Activo');

INSERT INTO `user` (`id_user`, `name`, `email`, `rut`, `username`, `password`, `state`, `User_type_id_user_type`) VALUES ('1', 'admin', 'admin@admin.com', '00.000.000-0', 'admin', 'YWRtaW4=', '1', '1');
