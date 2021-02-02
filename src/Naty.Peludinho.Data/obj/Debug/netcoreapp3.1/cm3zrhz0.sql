IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Pessoas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Sobrenome] varchar(200) NOT NULL,
    [DataNascimento] datetime2 NOT NULL,
    [Cpf] varchar(11) NOT NULL,
    [Telefone] varchar(13) NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Animais] (
    [Id] uniqueidentifier NOT NULL,
    [PessoaId] uniqueidentifier NOT NULL,
    [TipoAnimal] int NOT NULL,
    [Raca] varchar(100) NOT NULL,
    [Cor] varchar(100) NOT NULL,
    [Sexo] int NOT NULL,
    CONSTRAINT [PK_Animais] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Animais_Pessoas_PessoaId] FOREIGN KEY ([PessoaId]) REFERENCES [Pessoas] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [PessoaId] uniqueidentifier NOT NULL,
    [Logradouro] varchar(200) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(250) NULL,
    [Cep] varchar(8) NOT NULL,
    [Bairro] varchar(100) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(50) NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos_Pessoas_PessoaId] FOREIGN KEY ([PessoaId]) REFERENCES [Pessoas] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Animais_PessoaId] ON [Animais] ([PessoaId]);
GO

CREATE UNIQUE INDEX [IX_Enderecos_PessoaId] ON [Enderecos] ([PessoaId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210202144628_Initial', N'5.0.2');
GO

COMMIT;
GO

