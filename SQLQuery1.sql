select distinct P.Lot_SrNo,P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,
P.Optic,P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, 
convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, 
convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, 
B.BPL_No, B.Created_By, B.Created_Date 
from POUCH_LABEL P,BPL_GEN B 
where  P.BPL_NO=B.BPL_NO AND
 P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND 
P.BPL_NO='BPL/080612/19' order by Model_Name 

select convert(getdate(),103)


CONVERT(VARCHAR(8),GETDATE(),101) 
