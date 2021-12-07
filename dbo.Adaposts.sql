CREATE TABLE [dbo].[Adaposts] (
    [AdapostId] INT IDENTITY (1, 1) NOT NULL,
    [denumire]  NVARCHAR(50) NOT NULL,
    [adresa]    NVARCHAR(50) NOT NULL,
    [oras]      NVARCHAR(50) NOT NULL,
    [ContactId] INT NULL,
    [DoneazaId] INT NULL,
    CONSTRAINT [PK_Adaposts] PRIMARY KEY CLUSTERED ([AdapostId] ASC),
    CONSTRAINT [FK_Adaposts_Contact_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[Contact] ([ContactId]),
    CONSTRAINT [FK_Adaposts_Doneaza_DoneazaId] FOREIGN KEY ([DoneazaId]) REFERENCES [dbo].[Doneaza] ([DoneazaId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Adaposts_ContactId]
    ON [dbo].[Adaposts]([ContactId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Adaposts_DoneazaId]
    ON [dbo].[Adaposts]([DoneazaId] ASC);

