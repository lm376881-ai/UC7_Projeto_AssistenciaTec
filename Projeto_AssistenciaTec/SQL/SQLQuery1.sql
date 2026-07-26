CREATE TABLE tbl_clientes(
	cliente_id INT PRIMARY KEY IDENTITY,
	nome NVARCHAR(50) NOT NULL,
	email NVARCHAR(50) NOT NULL,
	telefone NVARCHAR(20) NOT NULL,
	endereco NVARCHAR (200) NULL
)

CREATE TABLE tbl_tecnicos(
	tecnico_id INT PRIMARY KEY IDENTITY,
	nome NVARCHAR(50) NOT NULL,
	email NVARCHAR(50) NOT NULL,
	telefone NVARCHAR(20) NOT NULL,
	endereco NVARCHAR (200)	NOT NULL,
	especialidade NVARCHAR(100) NOT NULL
)

CREATE TABLE tbl_ordem_servicos(
	ordem_servico_id INT PRIMARY KEY IDENTITY,
	data_abertura DATE NOT NULL,
	equipamento NVARCHAR(100) NOT NULL,
	defeito_relatado NVARCHAR(500) NOT NULL,
	avaliacao_tecnica NVARCHAR(500) NOT NULL,
	valor_estimado  DECIMAL(10,2) NOT NULL,
	tempo_estimado INT NOT NULL,
	data_conclusao DATE NULL,
	finalizado BIT NULL,
	cliente_id INT NOT NULL,
	tecnico_id INT  NOT NULL,
	CONSTRAINT fk_cliente_os FOREIGN KEY (cliente_id)
	REFERENCES tbl_clientes(cliente_id),
	CONSTRAINT fk_tecnico_os FOREIGN KEY (tecnico_id)
	REFERENCES tbl_tecnicos(tecnico_id)

)

drop table tbl_ordem_servicos

