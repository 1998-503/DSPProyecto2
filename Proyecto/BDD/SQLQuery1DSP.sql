Use BibliotecaDSP
go

Create table [Autor](
[IDAutor] [int] IDENTITY(1,1) NOT NULL,
	[FechaNacimiento] [nvarchar](15) NOT NULL,
	[Nacionalidad] [ntext] NULL,
	[Nombre] [ntext] NULL,
	[PrimerNombre] [ntext] NULL,
	[PrimerApellido] [ntext] NULL,
 CONSTRAINT [PK_IDAutor] PRIMARY KEY CLUSTERED 
(
[IDAutor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

Create table [Libro](
[IDLibro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](40) NOT NULL,
	[NumeroPagina] [nvarchar](30) NULL,
	[AñoEdicion] [nvarchar](31) NULL,
	[CopiaLibro] [ntext] NULL,
 CONSTRAINT [PK_IDLibro] PRIMARY KEY CLUSTERED
 (
 [IDLibro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

Create table [Editorial](
[IDEditorial] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Pais] [ntext] NULL,
 CONSTRAINT [PK_IDEditorial] PRIMARY KEY CLUSTERED 
(
[IDEditorial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

Create table [Usuario](
[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Apellido1] [ntext] NULL,
	[Apellido2] [ntext] NULL,
	[Direccion] [ntext] NULL,
	[Correo] [ntext] NULL,
	[Telefono] [ntext] NULL,
 CONSTRAINT [PK_IDUsuario] PRIMARY KEY CLUSTERED 
(
[IDUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

Create table [Prestamo](
[IDPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
	[CodigoLibre] [int] NOT NULL,
	[FechaRetirada] [ntext] NULL,
	[Devolucion] [ntext] NULL,
	[Observaciones] [ntext] NULL,
 CONSTRAINT [PK_IDPrestamo] PRIMARY KEY CLUSTERED 
(
[IDPrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [Autor]  WITH NOCHECK ADD  CONSTRAINT [FK_Autor_Libro] FOREIGN KEY([IDAutor])
REFERENCES [Libro] ([IDAutor])
GO

ALTER TABLE [Autor] CHECK CONSTRAINT [FK_Autor_Libro]
GO

ALTER TABLE [Autor]  WITH NOCHECK ADD  CONSTRAINT [FK_Autor_Libro] FOREIGN KEY([IDAutor])
REFERENCES [Libro] ([IDAutor])
GO