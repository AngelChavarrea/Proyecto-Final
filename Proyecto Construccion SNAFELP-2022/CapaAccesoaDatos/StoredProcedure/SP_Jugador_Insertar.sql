
Alter PROCEDURE SP_Jugador_Insertar
	@nombres varchar(100),
	@apellidos varchar(100),
	@cedula varchar(100),
	@fechanacimiento datetime,
	@telefono varchar(100),
	@nacionalidad varchar(100),
	@numero smallint
AS
BEGIN
	BEGIN TRY
		DECLARE @tbl TABLE (ID INT);
		BEGIN TRANSACTION
			INSERT INTO Jugador (nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, numero)
						 OUTPUT inserted.id_persona INTO @tbl(ID)
					     VALUES(@nombres,@apellidos,@cedula,@fechanacimiento,@telefono,@nacionalidad,@numero);
		COMMIT TRANSACTION
		Declare @id int;
		Set @id = (Select ID FROM @tbl);
		/*
		* @@IDENTITY
		* SCOPE_IDENTITY()
		* IDENT_CURRENT('nombre_tabla')
		* OUTPUT de la orden INSERT
		*/
		Return @id;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END;

/*
*	https://www.ramoncarrasco.es/es/content/es/kb/105/como-obtener-el-ultimo-id-generado-al-insertar-datos-en-una-tabla-de-sql-server
*	https://qastack.mx/programming/10999396/how-do-i-use-an-insert-statements-output-clause-to-get-the-identity-value
*/