USE InterviewZenQ3

SELECT OgrenciId , Ad , Soyad , AVG(ilkOrtalama +ikinciOrtalama)/2 AS GenelOrt from Student   WHERE �l ='istanbul' AND YEAR(GETDATE())-YEAR(Do�umTarihi) BETWEEN 20 AND 24 GROUP BY OgrenciId,Ad,Soyad;