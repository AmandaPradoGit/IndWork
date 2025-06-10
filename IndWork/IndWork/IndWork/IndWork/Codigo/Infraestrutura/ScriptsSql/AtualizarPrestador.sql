UPDATE Prestadores
	SET
		PessoaId = @PessoaId,
		CategoriasServico = @CategoriasServico
	WHERE
		Id = @Id

SELECT 
		Id
		PessoaId,
		CategoriasServico		
	FROM 
		Prestadores 
	WHERE 
		Id = @Id