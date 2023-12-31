USE [master]
GO
/****** Object:  Database [Kamil]    Script Date: 31/07/2023 05:46:50 p. m. ******/
CREATE DATABASE [Kamil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kamil', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS02\MSSQL\DATA\Kamil.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kamil_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS02\MSSQL\DATA\Kamil_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Kamil] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kamil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kamil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kamil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kamil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kamil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kamil] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kamil] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Kamil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kamil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kamil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kamil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kamil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kamil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kamil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kamil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kamil] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kamil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kamil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kamil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kamil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kamil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kamil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kamil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kamil] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kamil] SET  MULTI_USER 
GO
ALTER DATABASE [Kamil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kamil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kamil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kamil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kamil] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kamil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Kamil] SET QUERY_STORE = ON
GO
ALTER DATABASE [Kamil] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Kamil]
GO
/****** Object:  Table [dbo].[Catalogo_centros]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_centros](
	[num_centro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[ciudad] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Catalogo_centros] PRIMARY KEY CLUSTERED 
(
	[num_centro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catalogo_puestos]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_puestos](
	[num_puesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Catalogo_puestos] PRIMARY KEY CLUSTERED 
(
	[num_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directivos]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directivos](
	[num_directivo] [int] IDENTITY(1,1) NOT NULL,
	[centro_sup] [nvarchar](max) NOT NULL,
	[prestacion_comb] [int] NOT NULL,
	[num_empleado] [int] NULL,
 CONSTRAINT [PK_Directivos] PRIMARY KEY CLUSTERED 
(
	[num_directivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[num_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[apellido_paterno] [nvarchar](max) NOT NULL,
	[apellido_materno] [nvarchar](max) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[RFC] [nvarchar](max) NOT NULL,
	[num_centro] [int] NOT NULL,
	[num_puesto] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[num_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Catalogo_centros] FOREIGN KEY([num_centro])
REFERENCES [dbo].[Catalogo_centros] ([num_centro])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Catalogo_centros]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Catalogo_puestos] FOREIGN KEY([num_puesto])
REFERENCES [dbo].[Catalogo_puestos] ([num_puesto])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Catalogo_puestos]
GO
/****** Object:  StoredProcedure [dbo].[CatalogoCentrosCrudOperation]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Yogeshkumar Hadiya>
-- Description: <Perform crud operation on employee table>
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoCentrosCrudOperation]
    -- Add the parameters for the stored procedure here
    @Num_Centro int,
    @Nombre nvarchar(50),
    @Ciudad nvarchar(50),
    @OperationType int
    --================================================
    --operation types
    -- 1) Insert
    -- 2) Update
    -- 3) Delete
    -- 4) Select Perticular Record
    -- 5) Selec All
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    --select operation
    IF @OperationType=1
    BEGIN
        INSERT INTO Catalogo_Centros VALUES (@Nombre,@Ciudad)
    END
    ELSE IF @OperationType=2
    BEGIN
        UPDATE Catalogo_Centros SET Nombre=@Nombre , Ciudad=@Ciudad WHERE Num_Centro=@Num_Centro
    END
    ELSE IF @OperationType=3
    BEGIN
        DELETE FROM Catalogo_Centros WHERE Num_Centro=@Num_Centro
    END
    ELSE IF @OperationType=4
    BEGIN
        SELECT * FROM Catalogo_Centros WHERE Num_Centro=@Num_Centro
    END
    ELSE
    BEGIN
        SELECT * FROM Catalogo_Centros
    END
END
GO
/****** Object:  StoredProcedure [dbo].[CatalogoDirectivosCrudOperation]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Yogeshkumar Hadiya>
-- Description: <Perform crud operation on employee table>
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoDirectivosCrudOperation]
    -- Add the parameters for the stored procedure here
    @Num_Directivo int,
    @CentroSupervisado nvarchar(50),
    @Prestacion nvarchar(50),
	@Num_empleado nvarchar(50),
    @OperationType int
    --================================================
    --operation types
    -- 1) Insert
    -- 2) Update
    -- 3) Delete
    -- 4) Select Perticular Record
    -- 5) Selec All
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    --select operation
    IF @OperationType=1
    BEGIN
		SELECT * FROM Directivos
	
        INSERT INTO Directivos VALUES (@CentroSupervisado,@Prestacion,@Num_empleado)
    END
    ELSE IF @OperationType=2
    BEGIN
        UPDATE Directivos SET centro_sup=@CentroSupervisado , prestacion_comb=@Prestacion, num_empleado=@Num_empleado WHERE num_directivo=@Num_Directivo
    END
    ELSE IF @OperationType=3
    BEGIN
        DELETE FROM Directivos WHERE num_directivo=@Num_Directivo
    END
    ELSE IF @OperationType=4
    BEGIN
        SELECT * FROM Directivos WHERE num_directivo=@Num_Directivo
    END
    ELSE
    BEGIN
        SELECT * FROM Directivos
    END
END
GO
/****** Object:  StoredProcedure [dbo].[CatalogoEmpleadosCrudOperation]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Yogeshkumar Hadiya>
-- Description: <Perform crud operation on employee table>
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoEmpleadosCrudOperation]
    -- Add the parameters for the stored procedure here
    @Num_Empleado int,
    @Nombre nvarchar(50),
    @Apellido_Paterno nvarchar(50),
	@Apellido_Materno nvarchar(50),
	@Fecha_Nacimiento DATE,
	@RFC nvarchar(50),
	@Num_centro INT,
	@Num_puesto INT,
    @OperationType int
    --================================================
    --operation types
    -- 1) Insert
    -- 2) Update
    -- 3) Delete
    -- 4) Select Perticular Record
    -- 5) Selec All
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    --select operation
    IF @OperationType=1
    BEGIN
	
        INSERT INTO Empleados VALUES (@Nombre,@Apellido_Paterno,@Apellido_Materno,@Fecha_Nacimiento,@RFC,convert (int, @Num_centro),convert (int, @Num_puesto))
    END
    ELSE IF @OperationType=2
    BEGIN
        UPDATE Empleados SET Nombre=@Nombre , apellido_paterno=@Apellido_Paterno, apellido_materno=@Apellido_Materno, fecha_nacimiento=@Fecha_Nacimiento, RFC=@RFC, num_centro=@Num_centro, num_puesto = @Num_puesto  WHERE num_empleado=num_empleado
    END
    ELSE IF @OperationType=3
    BEGIN
        DELETE FROM Empleados WHERE num_empleado=@Num_Empleado
    END
    ELSE IF @OperationType=4
    BEGIN

        SELECT num_empleado, e.nombre,e.apellido_paterno, e.apellido_materno, e.fecha_nacimiento,e.RFC, c.nombre AS nombre_Centro,p.nombre AS nombre_puesto FROM Empleados AS e JOIN Catalogo_centros AS c ON e.num_centro = c.num_centro JOIN Catalogo_puestos AS p ON e.num_puesto = p.num_puesto WHERE e.num_empleado=@Num_Empleado
    END
    ELSE
    BEGIN
        SELECT * FROM Empleados
    END
END
GO
/****** Object:  StoredProcedure [dbo].[CatalogoPuestosCrudOperation]    Script Date: 31/07/2023 05:46:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Yogeshkumar Hadiya>
-- Description: <Perform crud operation on employee table>
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoPuestosCrudOperation]
    -- Add the parameters for the stored procedure here
    @Num_Puesto int,
    @Nombre nvarchar(50),
    @Descripcion nvarchar(50),
    @OperationType int
    --================================================
    --operation types
    -- 1) Insert
    -- 2) Update
    -- 3) Delete
    -- 4) Select Perticular Record
    -- 5) Selec All
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    --select operation
    IF @OperationType=1
    BEGIN

	SELECT * FROM Catalogo_puestos
        INSERT INTO Catalogo_puestos VALUES (@Nombre,@Descripcion)
    END
    ELSE IF @OperationType=2
    BEGIN
        UPDATE Catalogo_puestos SET Nombre=@Nombre , descripcion=@Descripcion WHERE num_puesto=@Num_Puesto
    END
    ELSE IF @OperationType=3
    BEGIN
        DELETE FROM Catalogo_puestos WHERE num_puesto=@Num_Puesto
    END
    ELSE IF @OperationType=4
    BEGIN
        SELECT * FROM Catalogo_puestos WHERE num_puesto=@Num_Puesto
    END
    ELSE
    BEGIN
        SELECT * FROM Catalogo_puestos
    END
END
GO
USE [master]
GO
ALTER DATABASE [Kamil] SET  READ_WRITE 
GO
