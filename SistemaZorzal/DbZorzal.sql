USE [DbelZorzal]
GO
/****** Object:  Table [dbo].[tbBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBoleta](
	[Serie] [varchar](3) NOT NULL,
	[Numero] [varchar](6) NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [decimal](18, 2) NULL,
	[Estado] [varchar](1) NULL,
	[Fruc] [varchar](11) NULL,
	[FdniCliente] [varchar](8) NULL,
	[FCodigoEmpleado] [nvarchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[Serie] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCargo]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCargo](
	[idCargo] [nvarchar](10) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbCargo] PRIMARY KEY CLUSTERED 
(
	[idCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCliente](
	[DNI] [varchar](8) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](max) NULL,
 CONSTRAINT [PK_tbCliente] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDetalle]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDetalle](
	[Serie] [varchar](3) NULL,
	[Numero] [varchar](6) NULL,
	[FCodProducto] [nvarchar](6) NULL,
	[CantActual] [int] NULL,
	[CantCompra] [int] NULL,
	[Importe] [decimal](18, 2) NULL,
	[IDDetalle] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmpleado](
	[Codigo] [nvarchar](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Cargo] [nvarchar](10) NOT NULL,
	[Clave] [nvarchar](6) NOT NULL,
	[Estado] [nvarchar](5) NOT NULL,
	[Foto] [text] NULL,
 CONSTRAINT [PK_tbEmpleado] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmpresa]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmpresa](
	[Ruc] [varchar](11) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](max) NULL,
	[Telefono] [varchar](11) NULL,
	[Foto] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ruc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbHabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHabitacion](
	[NroHabitacion] [int] NOT NULL,
	[TipoHabitacion] [nvarchar](100) NULL,
	[PrecioHabitacion] [int] NULL,
	[LimpiezaHab] [nvarchar](100) NULL,
	[EstadoHab] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbHabitacion] PRIMARY KEY CLUSTERED 
(
	[NroHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducto](
	[Codigo] [nvarchar](6) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Cantidad] [nvarchar](3) NOT NULL,
	[PrecioUnitario] [numeric](6, 2) NOT NULL,
 CONSTRAINT [PK_tbProducto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProveedor](
	[Codigo] [varchar](6) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Ruc] [varchar](11) NOT NULL,
	[Email] [varchar](max) NULL,
 CONSTRAINT [PK_tbProveedor] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRegistroHabCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRegistroHabCliente](
	[NroRegistro] [int] IDENTITY(1,1) NOT NULL,
	[NomEncargado] [nvarchar](100) NULL,
	[DniCliente] [nvarchar](100) NULL,
	[NomCliente] [nvarchar](100) NULL,
	[NroHabitacion] [nvarchar](100) NULL,
	[Costo] [nvarchar](100) NULL,
	[FechayHoraEntrada] [datetime] NULL,
	[TiempoAlquilado] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSalidas]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSalidas](
	[idSalida] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](3) NULL,
	[Numero] [varchar](6) NULL,
	[Fcodprod] [varchar](8) NULL,
	[Cant_Salida] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbVentaProd]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVentaProd](
	[NroRegistro] [int] IDENTITY(1,1) NOT NULL,
	[DniCli] [nvarchar](50) NOT NULL,
	[Codigo] [nvarchar](100) NULL,
	[Cantidad] [nvarchar](100) NULL,
	[PrecioUnit] [nvarchar](100) NULL,
	[CantidadCompra] [nvarchar](100) NULL,
	[Importe] [decimal](2, 0) NULL,
	[ImporteFinal] [nvarchar](100) NULL,
	[Estado] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000001', CAST(N'2019-06-24T00:00:00.000' AS DateTime), CAST(150.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000001', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000002', CAST(N'2019-06-22T00:00:00.000' AS DateTime), CAST(160.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000002', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000003', CAST(N'2019-05-30T00:00:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000003', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000004', CAST(N'2019-05-28T00:00:00.000' AS DateTime), CAST(350.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000004', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000005', CAST(N'2019-05-22T00:00:00.000' AS DateTime), CAST(120.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000005', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000006', CAST(N'2019-05-10T00:00:00.000' AS DateTime), CAST(320.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000006', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000007', CAST(N'2019-04-15T00:00:00.000' AS DateTime), CAST(300.00 AS Decimal(18, 2)), N'1', N'11111111111', N'00000007', N'000001')
INSERT [dbo].[tbBoleta] ([Serie], [Numero], [Fecha], [Total], [Estado], [Fruc], [FdniCliente], [FCodigoEmpleado]) VALUES (N'001', N'000008', CAST(N'2019-06-24T00:00:00.000' AS DateTime), CAST(75.00 AS Decimal(18, 2)), N'1', N'10005065416', N'00000017', N'empty')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'1', N'Administador')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'2', N'Cajero')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'3', N'Almacen')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'4', N'Vendedor')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'5', N'Ayudante de vendeodor')
INSERT [dbo].[tbCargo] ([idCargo], [Descripcion]) VALUES (N'6', N'Ayudante de Cajero')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000001', N'Sergio Raul', N'Ramos Rojas', N'SergioRamos@hotmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000002', N'Diego Jose', N'Luque Quispe', N'Diego@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000003', N'Joel Armando', N'Rojas Chullunquia', N'rojaschu@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000008', N'Raul Jose', N'Jimenez Aranda', N'RaulJose@hotmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000009', N'Samuel Pedro', N'Hernandez Flores', N'SamuelHf@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000010', N'Luz Maria', N'Mamani Maquera', N'LuzM@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000011', N'Luana ', N'Pereira', N'lupere@hotmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000012', N'Rosa Daniela', N'Torres Arancibia', N'rosaara@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000013', N'Juan Miguel', N'Mamani Quispe', N'JuanMiguel@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000014', N'Luz Reina', N'Chavez Ticona', N'chatico@hotmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000015', N'Abimael Fernando', N'Paz maquera', N'abfer@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000016', N'Juana Gloria', N'Vilca Condori', N'juanaglo@gmail.com')
INSERT [dbo].[tbCliente] ([DNI], [Nombre], [Apellido], [Email]) VALUES (N'00000017', N'Salul', N'Lopez', N'salu@hotmail.com')
INSERT [dbo].[tbEmpleado] ([Codigo], [Nombre], [Apellido], [Cargo], [Clave], [Estado], [Foto]) VALUES (N'12345678', N'Roberto Carlos', N'Zegarra Reyes', N'1', N'123456', N'True', N'E:Example.jpg')
INSERT [dbo].[tbEmpleado] ([Codigo], [Nombre], [Apellido], [Cargo], [Clave], [Estado], [Foto]) VALUES (N'66666666', N'Diego', N'Diego', N'2', N'666666', N'True', N'C:\Users\Usuario\Desktop\1.png')
INSERT [dbo].[tbEmpleado] ([Codigo], [Nombre], [Apellido], [Cargo], [Clave], [Estado], [Foto]) VALUES (N'7777777', N'stre', N'stre', N'1', N'777777', N'True', N'example')
INSERT [dbo].[tbEmpleado] ([Codigo], [Nombre], [Apellido], [Cargo], [Clave], [Estado], [Foto]) VALUES (N'87654321', N'Carlos Roberto', N'Reyes Zegarra', N'2', N'951951', N'True', N'C:\Users\Usuario\Desktop\escena.jpg')
INSERT [dbo].[tbEmpleado] ([Codigo], [Nombre], [Apellido], [Cargo], [Clave], [Estado], [Foto]) VALUES (N'88888888', N'stre', N'stre', N'1', N'888888', N'True', N'C:\Users\Usuario\Desktop\d.jpg')
INSERT [dbo].[tbEmpresa] ([Ruc], [Nombre], [Direccion], [Telefono], [Foto]) VALUES (N'11111111111', N'Sonic Sac', N'Solari', N'11111111111', N'E:\Example.jpg')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (100, N'Matrimonial', 200, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (110, N'Personal', 100, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (120, N'Matrimonial', 200, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (130, N'Doble', 150, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (140, N'Personal', 100, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (150, N'Matrimonial', 200, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (160, N'Doble', 150, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (170, N'Matrimonial', 200, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (180, N'Doble', 150, N'0', N'1')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (190, N'Personal', 100, N'0', N'0')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (200, N'Matrimonial', 200, N'0', N'0')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (210, N'Personal', 100, N'0', N'0')
INSERT [dbo].[tbHabitacion] ([NroHabitacion], [TipoHabitacion], [PrecioHabitacion], [LimpiezaHab], [EstadoHab]) VALUES (220, N'Matrimonial', 200, N'0', N'0')
INSERT [dbo].[tbProducto] ([Codigo], [Descripcion], [Cantidad], [PrecioUnitario]) VALUES (N'000001', N'Vino', N'350', CAST(15.00 AS Numeric(6, 2)))
INSERT [dbo].[tbProducto] ([Codigo], [Descripcion], [Cantidad], [PrecioUnitario]) VALUES (N'000002', N'Vino blanco', N'420', CAST(15.00 AS Numeric(6, 2)))
INSERT [dbo].[tbProducto] ([Codigo], [Descripcion], [Cantidad], [PrecioUnitario]) VALUES (N'000005', N'xxxx', N'0', CAST(0.00 AS Numeric(6, 2)))
INSERT [dbo].[tbProducto] ([Codigo], [Descripcion], [Cantidad], [PrecioUnitario]) VALUES (N'000008', N'Leche', N'100', CAST(5.00 AS Numeric(6, 2)))
INSERT [dbo].[tbProveedor] ([Codigo], [Nombre], [Direccion], [Telefono], [Ruc], [Email]) VALUES (N'123410', N'Sonic Sac', N'Solari', N'987654321', N'55555555555', N'osonic@gmail.com')
INSERT [dbo].[tbProveedor] ([Codigo], [Nombre], [Direccion], [Telefono], [Ruc], [Email]) VALUES (N'123456', N'Castilo', N'Solari', N'987654321', N'11111111111', N'osonic@gmail.com')
INSERT [dbo].[tbProveedor] ([Codigo], [Nombre], [Direccion], [Telefono], [Ruc], [Email]) VALUES (N'123457', N'Queirolo', N'Solari', N'987654321', N'22222222222', N'osonic@gmail.com')
INSERT [dbo].[tbProveedor] ([Codigo], [Nombre], [Direccion], [Telefono], [Ruc], [Email]) VALUES (N'123458', N'Casaretto', N'Solari', N'987654321', N'33333333333', N'osonic@gmail.com')
INSERT [dbo].[tbProveedor] ([Codigo], [Nombre], [Direccion], [Telefono], [Ruc], [Email]) VALUES (N'123459', N'D''artaggnam', N'Solari', N'987654321', N'44444444444', N'osonic@gmail.com')
SET IDENTITY_INSERT [dbo].[tbRegistroHabCliente] ON 

INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (1, N'Roberto', N'00000010', N'Raul Jose', N'120', N'400', CAST(N'2019-06-17T13:52:10.000' AS DateTime), N'2 dias')
INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (2, N'Juan', N'55555555', N'Pedro', N'150', N'300', CAST(N'2019-06-12T14:00:10.000' AS DateTime), N'4 dias')
INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (10, N'Roberto Carlos Zegarra Reyes', N'00000002', N'Diego Jose', N'220', N'400', CAST(N'2019-06-19T07:42:30.000' AS DateTime), N'2 dias')
INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (12, N'Roberto Carlos Zegarra Reyes', N'00000017', N'Salul', N'130', N'300', CAST(N'2019-06-24T12:00:48.000' AS DateTime), N'2 dias')
INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (5, N'Roberto Carlos Zegarra Reyes', N'00000008', N'Raul Jose', N'140', N'300', CAST(N'2019-06-19T06:36:10.000' AS DateTime), N'8 horas')
INSERT [dbo].[tbRegistroHabCliente] ([NroRegistro], [NomEncargado], [DniCliente], [NomCliente], [NroHabitacion], [Costo], [FechayHoraEntrada], [TiempoAlquilado]) VALUES (11, N'Roberto Carlos Zegarra Reyes', N'00000003', N'Joel Armando', N'170', N'80', CAST(N'2019-06-19T07:44:10.000' AS DateTime), N'8 horas')
SET IDENTITY_INSERT [dbo].[tbRegistroHabCliente] OFF
SET IDENTITY_INSERT [dbo].[tbSalidas] ON 

INSERT [dbo].[tbSalidas] ([idSalida], [Serie], [Numero], [Fcodprod], [Cant_Salida]) VALUES (2, N'001', N'000001', N'000001', N'1200')
INSERT [dbo].[tbSalidas] ([idSalida], [Serie], [Numero], [Fcodprod], [Cant_Salida]) VALUES (3, N'001', N'000002', N'000003', N'1140')
INSERT [dbo].[tbSalidas] ([idSalida], [Serie], [Numero], [Fcodprod], [Cant_Salida]) VALUES (4, N'001', N'000003', N'000002', N'180')
INSERT [dbo].[tbSalidas] ([idSalida], [Serie], [Numero], [Fcodprod], [Cant_Salida]) VALUES (5, N'001', N'000003', N'000004', N'720')
INSERT [dbo].[tbSalidas] ([idSalida], [Serie], [Numero], [Fcodprod], [Cant_Salida]) VALUES (6, N'001', N'000003', N'000004', N'180')
SET IDENTITY_INSERT [dbo].[tbSalidas] OFF
SET IDENTITY_INSERT [dbo].[tbVentaProd] ON 

INSERT [dbo].[tbVentaProd] ([NroRegistro], [DniCli], [Codigo], [Cantidad], [PrecioUnit], [CantidadCompra], [Importe], [ImporteFinal], [Estado]) VALUES (1, N'00000010', N'000001', N'2', N'10', N'10', CAST(10 AS Decimal(2, 0)), N'10', N'1         ')
INSERT [dbo].[tbVentaProd] ([NroRegistro], [DniCli], [Codigo], [Cantidad], [PrecioUnit], [CantidadCompra], [Importe], [ImporteFinal], [Estado]) VALUES (2, N'00000017', N'0000010', N'349', N'15.00', N'1', CAST(15 AS Decimal(2, 0)), N'15', N'1         ')
INSERT [dbo].[tbVentaProd] ([NroRegistro], [DniCli], [Codigo], [Cantidad], [PrecioUnit], [CantidadCompra], [Importe], [ImporteFinal], [Estado]) VALUES (3, N'00000017', N'000002', N'417', N'15.00', N'3', CAST(45 AS Decimal(2, 0)), N'45', N'1         ')
INSERT [dbo].[tbVentaProd] ([NroRegistro], [DniCli], [Codigo], [Cantidad], [PrecioUnit], [CantidadCompra], [Importe], [ImporteFinal], [Estado]) VALUES (4, N'00000017', N'000002', N'419', N'15.00', N'1', CAST(15 AS Decimal(2, 0)), N'75', N'1         ')
SET IDENTITY_INSERT [dbo].[tbVentaProd] OFF
ALTER TABLE [dbo].[tbDetalle]  WITH CHECK ADD  CONSTRAINT [FK_detalle_Boletaserie] FOREIGN KEY([Serie], [Numero])
REFERENCES [dbo].[tbBoleta] ([Serie], [Numero])
GO
ALTER TABLE [dbo].[tbDetalle] CHECK CONSTRAINT [FK_detalle_Boletaserie]
GO
ALTER TABLE [dbo].[tbEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_cargo] FOREIGN KEY([Cargo])
REFERENCES [dbo].[tbCargo] ([idCargo])
GO
ALTER TABLE [dbo].[tbEmpleado] CHECK CONSTRAINT [FK_Empleado_cargo]
GO
/****** Object:  StoredProcedure [dbo].[USP_Agregar_Salida]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_Agregar_Salida]
@Serie varchar(3),
@Numero varchar(6),
@FCodProducto varchar(8),
@Cant_Salida varchar(10)
as
begin
insert into tbSalidas(Serie,Numero,Fcodprod,Cant_Salida)
values (@Serie,@Numero,@FCodProducto,@Cant_Salida)
end



GO
/****** Object:  StoredProcedure [dbo].[USP_D_EliminarCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_D_EliminarCliente]
@DniCli varchar(8)
as 
begin 
Delete tbCliente
where 
DNI=@DniCli
end

GO
/****** Object:  StoredProcedure [dbo].[USP_D_EliminarEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_D_EliminarEmpleado]
@Codigo varchar(8)
as 
begin 
Delete tbEmpleado
where 
Codigo=@Codigo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_D_ELIMINARPRODUCTO]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_D_ELIMINARPRODUCTO]
@CODproducto varchar(6)
as 
begin 
Delete tbProducto
where 
Codigo=@CODproducto
end

GO
/****** Object:  StoredProcedure [dbo].[USP_D_EliminarProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_D_EliminarProveedor]
@CodigoProv varchar(6)
as 
begin 
Delete tbProveedor
where 
Codigo=@CodigoProv
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_I_AgregarBoleta]
@SerieBo varchar(3),
@NumeroBo varchar(6),
@FechaBo datetime,
@TotalBo decimal(18,2),
@EstadoBo varchar(1),
@Fruc varchar(11),
@Fdnicliente varchar(8),
@Fcodigoempleado nvarchar(8)
as
begin
insert into tbBoleta(Serie,Numero,Fecha,Total,Estado,Fruc,FdniCliente,FCodigoEmpleado)
values (@SerieBo,@NumeroBo,@FechaBo,@TotalBo,@EstadoBo,@Fruc,@Fdnicliente,@Fcodigoempleado)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarCargo]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_I_AgregarCargo]
@IDCargo NVARCHAR (10), 
@DESCargo VARCHAR (50)
As 

Begin
insert into tbCargo(idcargo,Descripcion)
values (@IDCargo , @DESCargo)
End 

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_I_AgregarCliente]
@DniCli varchar(8),
@NombreCli varchar(40),
@ApellidoCli varchar(50),
@EmailCli varchar(max)
as 
begin
insert into tbCliente (DNI,Nombre,Apellido,Email)
values (@DniCli,@NombreCli,@ApellidoCli,@EmailCli)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AGREGARCOMPROBANTE]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_I_AGREGARCOMPROBANTE]
@SerieBo varchar(3),
@NumeroBo varchar(6),
@FechaBo datetime,
@TotalBo decimal(18,2),
@Fruc varchar(11),
@Fdnicliente varchar(8),
@Fcodigoempleado nvarchar(8),
@EstadoBol varchar(20)
as
begin
insert into tbBoleta(Serie,Numero,Fecha,Total,Fruc,FdniCliente,FCodigoEmpleado,Estado)
values (@SerieBo,@NumeroBo,@FechaBo,@TotalBo,@Fruc,@Fdnicliente,@Fcodigoempleado,@Estadobol)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AGREGARDET]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_I_AGREGARDET]
@Serie varchar(3),
@Numero varchar(6),
@FCodProducto varchar(8),
@CantActual int,
@CantCompra int,
@Importe decimal (18,2)

as
begin
insert into tbDetalle(Serie,Numero,FCodProducto,CantActual,CantCompra,Importe)
values (@Serie,@Numero,@FCodProducto,@CantActual,@CantCompra,@Importe)
end


GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarDetalle]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_I_AgregarDetalle]
@Serie varchar(3),
@Numero varchar(6),
@CantCompra int,
@Importe decimal (18,2),
@FCodProducto nvarchar(6)
as
begin
insert into tbDetalle(Serie,Numero,CantCompra,Importe,FCodProducto)
values (@Serie,@Numero,@CantCompra,@Importe,@FCodProducto)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_I_AgregarEmpleado]
@CodigoEmpl varchar(8),
@NombreEmpl varchar(50),
@ApellidoEmpl varchar(50),
@CargoEmpl nvarchar(10),
@ClaveEmpl nvarchar(6),
@EstadoEmpl nvarchar(5),
@Foto text
as 
begin
insert into tbEmpleado( Codigo,Nombre,Apellido,Cargo,Clave,Estado,Foto)
values (@CodigoEmpl,@NombreEmpl,@ApellidoEmpl,@CargoEmpl,@ClaveEmpl,@EstadoEmpl,@Foto)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarEmpresa]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_I_AgregarEmpresa]
@RucEmp varchar(11),
@NombreEmp varchar(100),
@DireccionEmp varchar(max),
@TelefonoEmp varchar(11),
@FotoEmp text
as 
begin
insert into tbEmpresa(Ruc,Nombre,Direccion,Telefono,Foto)
values (@RucEmp,@NombreEmp,@DireccionEmp,@TelefonoEmp,@FotoEmp)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarHabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_I_AgregarHabitacion]
@NroHab int,
@TipoHab nvarchar(100),
@PreHab nvarchar(100),
@LimpHab nvarchar(100),
@EstaHab nvarchar(100)
as 
begin
insert into tbHabitacion (NroHabitacion,TipoHabitacion,PrecioHabitacion,LimpiezaHab,EstadoHab)
values (@NroHab,@TipoHab,@PreHab,@LimpHab,@EstaHab)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_I_AgregarProducto]
@CodigoPro nvarchar(6),
@DescripcionPro varchar(250),
@CantidadPro nvarchar(3),
@PrecioUnitarioPro numeric(6,2)

as
begin
insert into tbProducto(Codigo,Descripcion,Cantidad,PrecioUnitario)
values (@CodigoPro,@DescripcionPro,@CantidadPro,@PrecioUnitarioPro)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_AgregarProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_I_AgregarProveedor]
@CodigoProv varchar(6),
@NombreProv varchar(100),
@DireccionProv varchar(max),
@RucProv varchar(11),
@TelefonoProv varchar(9),
@EmailProv varchar(max)
as 
begin
insert into tbProveedor(Codigo,Nombre,Direccion,Ruc,Telefono,Email)
values (@CodigoProv,@NombreProv,@DireccionProv,@RucProv,@TelefonoProv,@EmailProv)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_RegistroHabCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_I_RegistroHabCliente]
@NomEncargado nvarchar(100),
@DniCliente nvarchar(100),
@NomCliente nvarchar(100),
@NroHabitacion nvarchar(100),
@Costo nvarchar(100),
@FechayHoraEntrada datetime,
@TiempoAlq nvarchar(100)

as 
begin
insert into tbRegistroHabCliente(NomEncargado, DniCliente,NomCliente,NroHabitacion,Costo,FechayHoraEntrada,TiempoAlquilado)
values (@NomEncargado,@DniCliente,@NomCliente,@NroHabitacion,@Costo,@FechayHoraEntrada,@TiempoAlq)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_I_VentaProd]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_I_VentaProd]
@DniCli nvarchar(100),
@Codigo nvarchar(100),
@Cantidad nvarchar(100),
@PrecioUnit nvarchar(100),
@CantidadCompra nvarchar(100),
@Importe nvarchar(100),
@ImporteFinal nvarchar(100),
@Estado nchar(1)
as 
begin
insert into tbVentaProd(DniCli,Codigo,Cantidad,PrecioUnit,CantidadCompra,Importe,ImporteFinal,Estado)
values (@DniCli,@Codigo,@Cantidad,@PrecioUnit,@CantidadCompra,@Importe,@ImporteFinal,@Estado)
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletaDia]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletaDia]
@Fecha1 datetime

as
begin
select * from tbBoleta where Fecha = @Fecha1 
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletaPer]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletaPer]
@Fecha1 datetime,
@Fecha2 datetime
as
begin
select * from tbBoleta where Fecha >= @Fecha1 and Fecha <= @Fecha2
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletasAnu]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletasAnu]
as
begin
select * from tbBoleta where Estado=0
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletasAnuDia]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletasAnuDia]
@Fecha1 datetime,
@Fecha2 datetime
as
begin
select * from tbBoleta where Fecha >= @Fecha1 and Fecha <= @Fecha2 and Estado=0
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletasAnuEmp]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletasAnuEmp]
@CodEmp nvarchar(8)
as
begin
select * from tbBoleta where Estado=0 and FCodigoEmpleado=@CodEmp
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_BoletasAnuPer]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_BoletasAnuPer]
@Fecha1 datetime,
@Fecha2 datetime
as
begin
select * from tbBoleta where Fecha >= @Fecha1 and Fecha <= @Fecha2 and Estado=0
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_GananciaDia]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_GananciaDia]
@Fecha1 datetime,
@Fecha2 datetime
as
begin
select sum(Total) from tbBoleta where Fecha >= @Fecha1 and Fecha <= @Fecha2
end

GO
/****** Object:  StoredProcedure [dbo].[USP_R_GananciaPer]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_R_GananciaPer]
@Fecha1 datetime,
@Fecha2 datetime
as
begin
select sum(Total) from tbBoleta where Fecha >= @Fecha1 and Fecha <= @Fecha2
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscaProdClienteDNI]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscaProdClienteDNI]
@DniCli nvarchar(8)
as
begin
select Codigo,CantidadCompra, PrecioUnit,Importe,ImporteFinal from tbVentaProd
where 
DniCli=@DniCli
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarBoleta]
@Serie varchar(3),
@Numero varchar(6)
as
begin
select *from tbBoleta
where 
Serie=@Serie and Numero=@Numero
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarCargo]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarCargo]
@idcargo nvarchar(10)
as
begin
select *from tbCargo
where 
idCargo=@idcargo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarCli]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscarCli]
@Dni varchar(8)
as
begin
select Nombre,Apellido,Email from tbCliente
where 
DNI=@Dni
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_BuscarCliente]
@DNiCli varchar(8)
as
begin
select *from tbCliente
where 
DNI=@DNiCli
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarCostoHabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscarCostoHabitacion]
@Dni nvarchar(8)
as
begin
select NroHabitacion,costo,FechayHoraEntrada from tbRegistroHabCliente
where 
DniCliente=@Dni
end


GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarCostoProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_BuscarCostoProducto]
@Dni varchar(8)
as
begin
select codigo, cantidad, PrecioUnit, CantidadCompra, Importe from tbVentaProd
where 
DniCli=@Dni
end
GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarDetalle]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarDetalle] 
/* Variables que ingresaran con valores nuevos */
@Serie varchar(3),
@Numero varchar(6)
as
begin /* Empezar */
select *from tbDetalle
where /* Cuado se cumpla la condicional*/
Serie=@Serie and Numero=@Numero /* Primera condicional AND segunda condicional (Solo se cumplen si las dos son verdaderas) */
end /* Terminar */

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarEmpleado]
@Codigo nvarchar(8)
as
begin
select *from tbEmpleado
where 
Codigo=@Codigo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarEmpresa]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarEmpresa]
@Ruc varchar(11)
as
begin
select *from tbEmpresa
where 
Ruc=@Ruc
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarHabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarHabitacion]
@NroHabitacion int
as
begin
select *from tbHabitacion
where 
NroHabitacion=@NroHabitacion
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarHabitacionAlquilada]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarHabitacionAlquilada]
@NroHabitacion int
as
begin
select * from tbRegistroHabCliente
where 
NroHabitacion=@NroHabitacion
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarImpFinal]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscarImpFinal]
@Dni varchar(8)
as
begin
select Sum(Importe) as "Importe" from tbVentaProd
where 
DniCli=@Dni
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarImporteFinal]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarImporteFinal]
@DniCli nvarchar(8)
as
begin
SELECT MAX(ImporteFinal) as "ImporteFinal" from tbVentaProd 
where 
DniCli =@DniCli
end


GO
/****** Object:  StoredProcedure [dbo].[USP_S_BUSCARNUMEROBOLETA]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_BUSCARNUMEROBOLETA]
as
begin
SELECT TOP 1 *
FROM tbBoleta
ORDER BY Numero DESC
end
GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarNumeroRegistro]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscarNumeroRegistro]

as
begin
SELECT MAX(NroRegistro) AS NumeroRegistro from tbVentaProd

end




GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarNumeroRegistroHab]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_S_BuscarNumeroRegistroHab]

as
begin
SELECT MAX(NroRegistro) AS NumeroRegistro from tbRegistroHabCliente

end



GO
/****** Object:  StoredProcedure [dbo].[USP_S_BUSCARNUMEROSALIDA]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_BUSCARNUMEROSALIDA]
as
begin
SELECT TOP 1 *
FROM tbSalidas
ORDER BY Numero DESC
end
GO
/****** Object:  StoredProcedure [dbo].[USP_S_BUSCARPARAANULAR]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_BUSCARPARAANULAR]
@Serie varchar(3),
@Numero varchar(6)

as
begin
Select Serie,Numero,FCodProducto,Cantidad,CantCompra  FROM tbProducto,tbDetalle
where
	Serie = @Serie and Numero = @Numero and FCodProducto = Codigo
end
GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarPro]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_BuscarPro]
@Codigo nvarchar(6)
as
begin
select Descripcion,Cantidad,PrecioUnitario from tbProducto
where 
Codigo=@Codigo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarProducto]
@Cod nvarchar(6)
as
begin
select *from tbProducto
where 
Codigo=@Cod
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarProductoTexto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  Procedure [dbo].[USP_S_BuscarProductoTexto]
@Descripcion nvarchar(6)
as
begin
 SELECT * FROM tbProducto where Descripcion=@Descripcion;
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_BuscarProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_BuscarProveedor]
@CodigoProv nvarchar(6)
as
begin
select *from tbProveedor
where 
Codigo=@CodigoProv
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_HabEstado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_HabEstado]

as 
begin 
Select * from tbHabitacion where EstadoHab = 0
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarBoleta]
as 
begin
select * from tbBoleta
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarCargo]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarCargo]
as 
begin
select * from tbCargo
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarCliente]
as 
begin
select * from tbCliente
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarDetalle]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarDetalle]
as 
begin
select * from tbDetalle
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* create procedure (NOMBRE DEL PROCEDIMIENTO)  */
create Procedure [dbo].[USP_S_ListarEmpleado]
/* Variables que ingresaran con valores nuevos */
as 
begin /* Empezar */
select * from tbEmpleado /* Seleccionar todo (*) de la tb(preferida) */
end /* Terminar */

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarEmpr]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_ListarEmpr]
as
begin
select Nombre,Telefono,Ruc,Foto from tbEmpresa
end

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarEmpresa]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarEmpresa]
as 
begin
select * from tbEmpresa
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarHabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_ListarHabitacion]
as 
begin
select * from tbHabitacion
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarProducto]
as 
begin
select * from tbProducto
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_S_ListarProveedor]
as 
begin
select * from tbProveedor
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarTotalCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListarTotalCliente]
AS
BEGIN
SELECT count(*) FROM tbCliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarTotalEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListarTotalEmpleado]
AS
BEGIN
SELECT count(*) FROM tbEmpleado;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarTotalProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListarTotalProducto]
AS
BEGIN
SELECT count(*) FROM tbProducto;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarTotalProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListarTotalProveedor]
AS
BEGIN
SELECT count(*) FROM tbProveedor;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListarTotalVentas]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListarTotalVentas]
AS
BEGIN
SELECT count(*) FROM tbBoleta;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ListBajoStockProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ListBajoStockProducto]
AS
BEGIN
SELECT * FROM tbProducto WHERE Cantidad<=5;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_Login]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_S_Login]
@CodigoEmp nvarchar (8),
@ClaveEmp nvarchar(6),
@EstadoEmp nvarchar(5)
as
begin
SELECT * FROM tbEmpleado
where 
Codigo=@CodigoEmp and Clave=@ClaveEmp and Estado=@EstadoEmp
end 

GO
/****** Object:  StoredProcedure [dbo].[USP_S_ObtenerProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_S_ObtenerProducto]
AS
BEGIN
select Codigo, Descripcion from tbProducto
END

GO
/****** Object:  StoredProcedure [dbo].[USP_S_PROVE]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_S_PROVE]
as
begin
Select Nombre From tbProveedor
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_ActualizarBoleta]
@SerieBo varchar(3),
@NumeroBo varchar(6),
@FechaBo datetime,
@TotalBo decimal(18,2),
@EstadoBo varchar(1),
@Fruc varchar(11),
@Fdnicliente varchar(8),
@Fcodigoempleado nvarchar(8)
as 
begin
UPDATE tbBoleta
set 
Numero=@NumeroBo,
Fecha=@FechaBo,
Total=@TotalBo,
Estado=@EstadoBo,
Fruc=@Fruc,
FdniCliente=@Fdnicliente,
FCodigoEmpleado=@Fcodigoempleado
where 
Serie=@SerieBo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarCargo]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_ActualizarCargo]
@idcargo nvarchar(10),
@Desc varchar(50)
as 
begin
UPDATE tbCargo
set 
Descripcion=@Desc

where 
idCargo=@idcargo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarCliente]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_ActualizarCliente]
@DniCli varchar(8),
@NombreCli varchar(40),
@ApellidoCli varchar(50),
@EmailCli varchar(max)
as 
begin
UPDATE tbCliente
set 
Nombre=@NombreCli,
Apellido=@ApellidoCli,
Email=@EmailCli
where 
DNI=@DniCli
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarEmpleado]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_U_ActualizarEmpleado]
@CodigoEmpl varchar(8),
@NombreEmpl varchar(50),
@ApellidoEmpl varchar(50),
@CargoEmpl nvarchar(10),
@ClaveEmpl nvarchar(6),
@EstadoEmpl nvarchar(5),
@Foto text
as 
begin
UPDATE tbEmpleado
set 
Nombre=@NombreEmpl,
Apellido=@ApellidoEmpl,
Cargo=@CargoEmpl,
Clave=@ClaveEmpl,
Estado=@EstadoEmpl,
Foto=@Foto

where 
Codigo=@CodigoEmpl
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarEmpresa]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_U_ActualizarEmpresa]
@RucEmp varchar(11),
@NombreEmp varchar(100),
@DireccionEmp varchar(max),
@TelefonoEmp varchar(11),
@FotoEmp  text
as 
begin
UPDATE tbEmpresa
set 
Nombre=@NombreEmp,
Direccion=@DireccionEmp,
Telefono=@TelefonoEmp,
Foto=@FotoEmp

where 
Ruc=@RucEmp
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarEstadohabitacion]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_ActualizarEstadohabitacion]
@NroHab int,
@EstadoHabitacion int


as 
begin
UPDATE tbHabitacion
set 
EstadoHab = @EstadoHabitacion
where 
NroHabitacion = @NroHab
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarProducto]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[USP_U_ActualizarProducto]
@CodigoPro nvarchar(6),
@DescripcionPro varchar(250),
@CantidadPro nvarchar(3),
@PrecioUnitarioPro numeric(6,2)

as 
begin
UPDATE tbProducto
set 
Descripcion=@DescripcionPro,
Cantidad=@CantidadPro,
PrecioUnitario=@PrecioUnitarioPro

where 
Codigo=@CodigoPro
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ActualizarProveedor]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_ActualizarProveedor]
@CodigoProv varchar(6),
@NombreProv varchar(100),
@DireccionProv varchar(max),
@RucProv varchar(11),
@TelefonoProv varchar(9),
@EmailProv varchar(max)
as 
begin
UPDATE tbProveedor
set 
Nombre=@NombreProv,
Direccion=@DireccionProv,
Ruc=@RucProv,
Telefono=@TelefonoProv,
Email=@EmailProv
where 
Codigo=@CodigoProv
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_ANULABOL]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_U_ANULABOL]
@Serie varchar(3),
@Numero varchar(6),
@Estadobol varchar(20)
as
begin
UPDATE tbBoleta
SET
Estado = @Estadobol
WHERE
	Serie = @Serie and Numero = @Numero

END


GO
/****** Object:  StoredProcedure [dbo].[USP_U_AnularBoleta]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[USP_U_AnularBoleta]
@Serie varchar(3),
@Numero varchar(6)
as 
begin
UPDATE tbBoleta
set 
Estado='0'
where 
Serie=@Serie and Numero=@Numero
end


GO
/****** Object:  StoredProcedure [dbo].[USP_U_AUMENTARPRODUCTO]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[USP_U_AUMENTARPRODUCTO]
@CODprod int,
@CANTprod int
as
begin
UPDATE tbProducto
SET
Cantidad = @CANTprod
Where
Codigo = @CODprod
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_RestaPro]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_U_RestaPro]
@Codigo nvarchar(6),
@Cantidad nvarchar(3)
as
begin
update tbProducto
set Cantidad=Cantidad - convert(int,@Cantidad)
where 
Codigo=@Codigo
end

GO
/****** Object:  StoredProcedure [dbo].[USP_U_SumPro]    Script Date: 24/06/2019 13:01:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_U_SumPro]
@Codigo nvarchar(6),
@Cantidad nvarchar(3)
as
begin
update tbProducto
set Cantidad=Cantidad+@Cantidad
where 
Codigo=@Codigo
end

GO
