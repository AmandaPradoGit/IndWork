INSERT INTO Pessoas
	(
		Nome, 
		DataNascimento, 
		Cpf, 
		Telefone, 
		Email, 
		Endereco, 
		Numero, 
		Bairro, 
		Cep
	) 
VALUES 
	(
		@Nome, 
		@DataNascimento, 
		@Cpf, 
		@Telefone, 
		@Email, 
		@Endereco, 
		@Numero, 
		@Bairro, 
		@Cep
	)

SELECT @@IDENTITY;