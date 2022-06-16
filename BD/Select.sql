-- Usado MySQL
-- Total  de pagamentos utilizando boleto por mês de 20222

USE desafio;

(SELECT "Janeiro" as mês, 
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total 
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-01-01' 
AND '2022-01-31')

UNION ALL

(SELECT "Fevereiro" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-02-01' 
AND '2022-02-28')

UNION ALL

(SELECT "Março" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-03-01' 
AND '2022-03-31')

UNION ALL

(SELECT "Abril" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-04-01' 
AND '2022-04-30')

UNION ALL

(SELECT "Maio" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-05-01' 
AND '2022-05-31')

UNION ALL

(SELECT "Junho" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-06-01' 
AND '2022-06-30')

UNION ALL

(SELECT "Julho" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-07-01' 
AND '2022-07-31')

UNION ALL

(SELECT "Agosto" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-08-01' 
AND '2022-08-31')

UNION ALL

(SELECT "Setembro" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-09-01' 
AND '2022-09-30')

UNION ALL

(SELECT "Outubro" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-10-01' 
AND '2022-10-31')

UNION ALL

(SELECT "Novembro" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-11-01' 
AND '2022-11-30')

UNION ALL

(SELECT "Dezembro" as mês,
CAST((sum(valor)/100) AS DECIMAL(10,2)) as total  
FROM PagamentoBoletos
WHERE data_pagamento BETWEEN '2022-12-01' 
AND '2022-12-31');