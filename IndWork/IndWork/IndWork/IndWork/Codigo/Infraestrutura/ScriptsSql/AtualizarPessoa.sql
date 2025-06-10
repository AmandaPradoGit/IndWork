UPDATE Pessoas
	SET
		Nome = @Nome, 
		DataNascimento = @DataNascimento, 
		Cpf = @Cpf, 
		Telefone = @Telefone, 
		Email = @Email, 
		Endereco = @Endereco, 
		Numero = @Numero, 
		Bairro = @Bairro, 
		Cep = @Cep
	WHERE
		Id = @Id

SELECT 
		Id,
		Nome, 
		DataNascimento, 
		Cpf, 
		Telefone, 
		Email, 
		Endereco, 
		Numero, 
		Bairro, 
		Cep		
	FROM 
		Pessoas 
	WHERE 
		Id = @Id