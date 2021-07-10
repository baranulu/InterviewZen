USE InterviewZenQ3

SELECT OgrenciId , Ad , Soyad , AVG(ilkOrtalama +ikinciOrtalama)/2 AS GenelOrt from Student   WHERE Ýl ='istanbul' AND YEAR(GETDATE())-YEAR(DoðumTarihi) BETWEEN 20 AND 24 GROUP BY OgrenciId,Ad,Soyad;