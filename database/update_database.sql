USE GTAServerAdmin;
GO

-- Add new column to Players table
ALTER TABLE Players
ADD Email NVARCHAR(255);
GO

-- Create an index on the Name column in the Players table for faster searches
CREATE INDEX IX_Players_Name
ON Players(Name);
GO
