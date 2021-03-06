-- MySQL Script generated by MySQL Workbench
-- 10/09/15 04:47:13
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema University
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema University
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `University` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `University` ;

-- -----------------------------------------------------
-- Table `University`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Faculties` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(45) NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Departments` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `FacultyId` INT NOT NULL COMMENT '',
  `Faculties_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Departments_Faculties_idx` (`Faculties_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Departments_Faculties`
    FOREIGN KEY (`Faculties_Id`)
    REFERENCES `University`.`Faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Professors` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(45) NULL COMMENT '',
  `FacultyId` INT NULL COMMENT '',
  `Departments_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Professors_Departments1_idx` (`Departments_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Professors_Departments1`
    FOREIGN KEY (`Departments_Id`)
    REFERENCES `University`.`Departments` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Students` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `FacultyId` INT NULL COMMENT '',
  `Faculties_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Students_Faculties1_idx` (`Faculties_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`Faculties_Id`)
    REFERENCES `University`.`Faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Titles` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(45) NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Titles_has_Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Titles_has_Professors` (
  `Titles_Id` INT NOT NULL COMMENT '',
  `Professors_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Titles_Id`, `Professors_Id`)  COMMENT '',
  INDEX `fk_Titles_has_Professors_Professors1_idx` (`Professors_Id` ASC)  COMMENT '',
  INDEX `fk_Titles_has_Professors_Titles1_idx` (`Titles_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Titles_has_Professors_Titles1`
    FOREIGN KEY (`Titles_Id`)
    REFERENCES `University`.`Titles` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Titles_has_Professors_Professors1`
    FOREIGN KEY (`Professors_Id`)
    REFERENCES `University`.`Professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Courses` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `ProfessorId` INT NULL COMMENT '',
  `Professors_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Courses_Professors1_idx` (`Professors_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Courses_Professors1`
    FOREIGN KEY (`Professors_Id`)
    REFERENCES `University`.`Professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`Courses_has_Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`Courses_has_Students` (
  `Courses_Id` INT NOT NULL COMMENT '',
  `Students_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Courses_Id`, `Students_Id`)  COMMENT '',
  INDEX `fk_Courses_has_Students_Students1_idx` (`Students_Id` ASC)  COMMENT '',
  INDEX `fk_Courses_has_Students_Courses1_idx` (`Courses_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Courses_has_Students_Courses1`
    FOREIGN KEY (`Courses_Id`)
    REFERENCES `University`.`Courses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_has_Students_Students1`
    FOREIGN KEY (`Students_Id`)
    REFERENCES `University`.`Students` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
