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