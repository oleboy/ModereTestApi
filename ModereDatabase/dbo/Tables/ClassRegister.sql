CREATE TABLE [dbo].[ClassRegister] (
    [ClassRegisterId] INT IDENTITY (1, 1) NOT NULL,
    [ClassId]         INT NOT NULL,
    [StudentId]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ClassRegisterId] ASC),
    CONSTRAINT [FK_ClassRegister_Class] FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Class] ([ClassId]),
    CONSTRAINT [FK_ClassRegister_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId])
);

