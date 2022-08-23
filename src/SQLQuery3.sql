Select * FROM dbo.AspNetUserRoles
Select * FROM dbo.AspNetRoles
select * from dbo.AspNetUsers
SELECT * FROM dbo.AspNetUserClaims

INSERT INTO dbo.AspNetUserClaims VALUES('fe2c50a8-31e9-4b8c-bed4-5d76b7c39d42','fe2c50a8-31e9-4b8c-bed4-5d76b7c39d35','Administrator')
INSERT INTO dbo.AspNetRoles(Id,Name,NormalizedName) VALUES ('fe2c50a8-31e9-4b8c-bed4-5d76b7c39d38','Administrator','Administrator')
INSERT INTO dbo.AspNetUserRoles VALUES('fe2c50a8-31e9-4b8c-bed4-5d76b7c39d35','fe2c50a8-31e9-4b8c-bed4-5d76b7c39d38')