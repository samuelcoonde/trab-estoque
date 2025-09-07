CREATE TABLE produto(
	id_prod SERIAL NOT NULL,
	nome_prod VARCHAR(45) NOT NULL,
	preco_prod DECIMAL(10, 2) NOT NULL,
	quantidade_prod INT DEFAULT 0,
	PRIMARY KEY(id_prod)
)

DROP TABLE produto;

INSERT INTO produto (nome_prod, preco_prod, quantidade_prod)
VALUES 
    ('Macarrão', 14.60, 3),
    ('Ovo', 120, 80),
    ('Arroz', 8.50, 5),
    ('Feijão', 9.30, 10),
    ('Açúcar', 5.20, 15),
    ('Leite', 4.50, 20),
    ('Café', 12.80, 8),
    ('Detergente', 3.25, 25),
    ('Sabão em pó', 18.90, 12),
    ('Óleo de soja', 7.40, 10),
    ('Pão de forma', 6.50, 7),
    ('Queijo', 22.30, 5),
    ('Presunto', 18.70, 6);

SELECT * FROM produtos;