INSERT INTO Prestadores
	(
		PessoaId,
		CategoriasServico
	) 
VALUES 
	(
		@PessoaId,
		@CategoriasServico
	)

SELECT @@IDENTITY;