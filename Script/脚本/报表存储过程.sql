-- Start of generated script for 220.128.5.3-DB2-LLZYDB (db2inst2)
--  Oct-30-2010 at 12:00:47

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_MZ_DAYREPORT"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP
 ) 
  SPECIFIC "DB2INST2"."SQL100813141037300"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  begin 

 declare cur_item cursor with hold  with return for 	 						   
select M.item_name,B.total_fee,B.ticketnum from BASE_STAT_MZKJ M 
   left outer join 
     (
         select   code,sum(total_fee) as total_fee,sum(ticketnum) as ticketnum from
                                        (
                                        select  c.mzkj_code as code,sum(b.total_fee) as total_fee,count(a.ticketnum) as ticketnum from  
                                                   (select ticketnum,costmasterid,chargecode,costdate,record_flag,accountid from mz_costmaster) a, 
                                                   (select costid,itemtype as bigitemcode,total_fee from mz_costorder) b ,  base_stat_item c   
                                         where a.costmasterid=b.costid and b.bigitemcode=c.code and a.costdate
                                         between V_BTIME  and V_ETIME   and a.record_flag in (0,1,2)   
                                        group by c.mzkj_code,total_fee,ticketnum
							            )A group by code
	)B   on M.code =B.code;
open cur_item;       
  
  
  
end;

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_MZ_FEERPT"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP, 
  IN "V_TYPE" INTEGER, 
  IN "V_MZDEPT" INTEGER, 
  OUT "ERR_CODE" INTEGER, 
  OUT "ERR_TEXT" CHARACTER(100)
 ) 
  SPECIFIC "DB2INST2"."SQL100903175053600"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  p1: begin  
	 
	declare v_presdept varchar(20);
	declare v_presdoc varchar(20);
	declare v_itemtype varchar(20); 
	declare v_count int;
	Declare   sSQL   varchar(1000);  
	 

declare global temporary table tmp_kjxmFee(
	���� varchar(20),
	ҽ�� varchar(20),
	�ϼ� decimal(18,2) DEFAULT 0,
    �в�ҩ decimal(18,2) DEFAULT 0,
	�г�ҩ decimal(18,2) DEFAULT 0,
	��ҩ decimal(18,2) DEFAULT 0,
	ҩƷ����С�� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	CT���� decimal(18,2) DEFAULT 0,
	����� decimal(18,2) DEFAULT 0,
	�ĵ�ͼ decimal(18,2) DEFAULT 0,
	B�� decimal(18,2) DEFAULT 0,
	��ɫB�� decimal(18,2) DEFAULT 0,
	θ�� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	�ؼ�����С�� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	����ע�� decimal(18,2) DEFAULT 0,
    ����ע�� decimal(18,2) DEFAULT 0,
	��λ�� decimal(18,2) DEFAULT 0,
    ���� decimal(18,2) DEFAULT 0,
	��ʯ�� decimal(18,2) DEFAULT 0,
	��ҩ�� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	��ǻ���� decimal(18,2) DEFAULT 0,
	������� decimal(18,2) DEFAULT 0,
	��ҩ���� decimal(18,2) DEFAULT 0,
	�س����� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	�������� decimal(18,2) DEFAULT 0,
	����� decimal(18,2) DEFAULT 0,
	���Ϸ� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��ѹ�� decimal(18,2) DEFAULT 0,
	�Һŷ� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	ҽ������С�� decimal(18,2) DEFAULT 0
	      )
     not logged on commit preserve rows with replace in usertemp1;
	 
	  
	 
	
	
	p2: begin
	   if(V_TYPE=1)
	   then
	     FOR each_record AS 
			 select
			   c.presdeptcode,c.presdoccode,itemtype,sum(b.total_fee) fee,date(a.costdate) as costdate
		       from mz_costmaster a left outer join mz_costorder b  on  a.costmasterid=b.costid  
			              left outer join mz_presmaster c on a.presmasterid=c.presmasterid
			   where  a.costdate between V_BTIME  and V_ETIME   and a.record_flag in (0,1,2)  
		       group by presdeptcode,presdoccode,itemtype,date(a.costdate)
			   order by  presdeptcode,presdoccode
          do
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   if( presdoccode='' or presdoccode='0')
		   then		  
		   set v_presdoc='δָ��';
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   
		  end if;
		 
		   select item_name into v_itemtype from base_stat_mzkj where code=(select mzkj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		 else
		   FOR each_record AS 
			 select
			   c.presdeptcode,c.presdoccode,itemtype,sum(b.total_fee) fee,date(a.costdate) as costdate
		       from mz_costmaster a left outer join mz_costorder b  on  a.costmasterid=b.costid  
			              left outer join mz_presmaster c on a.presmasterid=c.presmasterid
			   where  a.costdate between V_BTIME  and V_ETIME   and a.record_flag in (0,1,2)   and int(presdeptcode)=V_MZDEPT 
		       group by presdeptcode,presdoccode,itemtype,date(a.costdate)
			   order by  presdeptcode,presdoccode
          do
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   if( presdoccode='' or presdoccode='0' )
		   then		  
		   set v_presdoc='δָ��';
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   
		  end if;
		 
		   select item_name into v_itemtype from base_stat_mzkj where code=(select mzkj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  end if;
	    update session.tmp_kjxmFee set 
		ҩƷ����С��=(�в�ҩ + �г�ҩ + ��ҩ),
		�ؼ�����С��=(�������� + CT���� + ����� + �ĵ�ͼ  + B�� + ��ɫB��  + θ�� + ������),
		ҽ������С��=(���� +������+ ����ע��+  ����ע�� +��λ�� +   ���� + ��ʯ�� + ��ҩ��  + �������� + �������� + ��ǻ����+�������+ ��ҩ���� + �س����� 
		              + �������� + �������� + ��������+�����+���Ϸ�+����+��ѹ��+�Һŷ�+����+����);
		
		update session.tmp_kjxmFee set �ϼ�=(ҩƷ����С�� + �ؼ�����С�� + ҽ������С��);
		
   
   
   
  end p2;
  
  begin
   declare cur_01 cursor with return for
     select * from session.tmp_kjxmFee;
   open cur_01;
  end;
end p1;

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_ZY_COSTFEEDETAILE"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP, 
  IN "V_TYPE" INTEGER, 
  IN "V_ALLCHARGER" INTEGER
 ) 
  SPECIFIC "DB2INST2"."SQL100906103932700"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  p1: begin 
	  
	 
	Declare   sSQL   varchar(1000);   
	
 
declare global temporary table tmp_Fee(
	���� varchar(20),
	���� varchar(20),
	�����ܶ� decimal(18,2) DEFAULT 0,
    Ԥ���� decimal(18,2) DEFAULT 0,
	�ֽ��ղ��˿� decimal(18,2) DEFAULT 0,
	����Ƿ�� decimal(18,2) DEFAULT 0,
	�Է� decimal(18,2) DEFAULT 0, 
	���� decimal(18,2) DEFAULT 0,
	ְ��ҽ�� decimal(18,2) DEFAULT 0,
	����ҽ�� decimal(18,2) DEFAULT 0,
	ũ�� decimal(18,2) DEFAULT 0,
	��Ժְ�� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	�շ�Ա varchar(20),
	��ע varchar(100)	
	      )
     not logged on commit preserve rows with replace in usertemp1; 
	
	
	p2: begin
	   if(V_TYPE =1)
	    then
	     FOR each_record AS 
		 select e.name as ����,c.patname as ����, sum(a.total_fee) as �����ܶ�,
         sum(deptosit_fee) as Ԥ����,sum(reality_fee) as �ֽ��ղ��˿�,sum(village_fee) as ���˽��,
		 sum(self_fee+FAVOR_FEE-deptosit_fee-reality_fee) as ����Ƿ�� ,f.name as �շ�Ա,d.name as ��������
         from zy_costmaster a  left outer join  zy_patlist b
         on a.patlistid=b.patlistid  
		 left outer join patientinfo c on b.patid=c.patid		 
		 left outer join BASE_PATIENTTYPE d on a.pattype=d.code
		 left outer join BASE_DEPT_PROPERTY e on b.currdeptcode=char(e.dept_id)
         left outer join BASE_EMPLOYEE_PROPERTY f on a.chargecode=char(f.EMPLOYEE_ID)
		 where costdate>=V_BTIME  and costdate<=V_ETIME  
         group by e.name,a.patlistid,c.patname,f.name,d.name
			
          do		 
		      set sSQL='insert into session.tmp_Fee(����, ����,�����ܶ�,  Ԥ����,�ֽ��ղ��˿�,����Ƿ��,' || �������� || ',�շ�Ա) 
			    values('''|| ���� ||''','''|| ����||''',' || char(�����ܶ�) || ',
				      ' || char( Ԥ����) || ',' || char(�ֽ��ղ��˿�) || ',' || char(����Ƿ��) || ',' || char(���˽��) || ','''|| �շ�Ա ||''')';		 
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;	
		  
		
		  
		else
			FOR each_record AS 
		 select e.name as ����,c.patname as ����, sum(a.total_fee) as �����ܶ�,
         sum(deptosit_fee) as Ԥ����,sum(reality_fee) as �ֽ��ղ��˿�,sum(village_fee) as ���˽��,
		 sum(self_fee+FAVOR_FEE-deptosit_fee-reality_fee) as ����Ƿ�� ,f.name as �շ�Ա,d.name as ��������
         from zy_costmaster a  left outer join  zy_patlist b
         on a.patlistid=b.patlistid  
		 left outer join patientinfo c on b.patid=c.patid		 
		 left outer join BASE_PATIENTTYPE d on a.pattype=d.code
		 left outer join BASE_DEPT_PROPERTY e on b.currdeptcode=char(e.dept_id)
         left outer join BASE_EMPLOYEE_PROPERTY f on a.chargecode=char(f.EMPLOYEE_ID)
		 where costdate>=V_BTIME  and costdate<=V_ETIME  and a.chargecode=char(V_ALLCHARGER)
         group by e.name,a.patlistid,c.patname,f.name,d.name
			
          do		 
		      set sSQL='insert into session.tmp_Fee(����, ����,�����ܶ�,  Ԥ����,�ֽ��ղ��˿�,����Ƿ��,' || �������� || ',�շ�Ա) 
			    values('''|| ���� ||''','''|| ����||''',' || char(�����ܶ�) || ',
				      ' || char( Ԥ����) || ',' || char(�ֽ��ղ��˿�) || ',' || char(����Ƿ��) || ',' || char(���˽��) || ','''|| �շ�Ա ||''')';		 
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;	
   end if;
   
     insert into session.tmp_Fee 
		  select '�ϼ�' as ����,'' as  ����,sum(�����ܶ�) as �����ܶ�, sum(Ԥ����) as Ԥ����, sum(�ֽ��ղ��˿�) as �ֽ��ղ��˿�, sum(����Ƿ��) as ����Ƿ��,
		  sum(�Է�) as �Է�,sum(����) as ����,sum(ְ��ҽ��) as ְ��ҽ��,sum(����ҽ��) as ����ҽ��,sum(ũ��) as ũ��,sum(��Ժְ��) as ��Ժְ��,sum(����) as ����,'' as �շ�Ա,'' as ��ע
		  from session.tmp_Fee;
   
  end p2;
  begin
   declare cur_01 cursor with return for
     select * from session.tmp_Fee;
   open cur_01;
  end;
end p1;

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_ZY_DAYREPORT"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP, 
  IN "V_ALLCHARGER" BIGINT, 
  IN "V_TYPE" SMALLINT, 
  OUT "ERR_CODE" INTEGER, 
  OUT "ERR_TEXT" CHARACTER(100)
 ) 
  SPECIFIC "DB2INST2"."SQL100906112815600"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  p1: begin  
    
      
	
	declare v_chargecode varchar(20);
	declare v_count int;
	Declare   sSQL   varchar(1000);   
	
	
	

	
 
declare global temporary table tmp_DayFee(
	�շ�Ա varchar(20),
	Ԥ���� decimal(18,2) DEFAULT 0,
	Ԥ���˴� INTEGER DEFAULT 0,
    ��Ժҽ�Ʒ����ܶ� decimal(18,2) DEFAULT 0,
	��ԺԤ���� decimal(18,2) DEFAULT 0,
	��Ժ�ֽ��ջ��˿� decimal(18,2) DEFAULT 0,
	��Ժ����Ƿ�� decimal(18,2) DEFAULT 0,
	��Ժ�˴� decimal(18,2) DEFAULT 0,
	�ϼ� decimal(18,2) DEFAULT 0
	      )
     not logged on commit preserve rows with replace in usertemp1;
	 
	  
	
	
	
	p2: begin
	     if(V_TYPE=0) then  --�����շ�Ա
	    --����Ԥ����
	     FOR each_record AS 
			 select
			  chargecode,sum(total_fee) fee, count(*) num from zy_chargelist where costdate >=V_BTIME  and costdate<=V_ETIME  and chargecode=char(V_ALLCHARGER)
			  group by chargecode
          do
		   
		   select name into v_chargecode from DB2INST2.BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(chargecode);
		   
		   select count(*) into v_count from session.tmp_DayFee where �շ�Ա=v_chargecode;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_DayFee set Ԥ���� = Ԥ���� + ' || char(fee) || ', Ԥ���˴�=Ԥ���˴�+'|| char(num) ||' where  �շ�Ա= ''' || v_chargecode || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_DayFee(�շ�Ա,Ԥ����,Ԥ���˴�) values('''|| v_chargecode ||''','|| char(fee) ||','|| char(num) ||')';
		   end if;
		   set ERR_TEXT=sSQL;
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  --�����Ժ�������
		   FOR each_record1 AS 
			 select
			   chargecode,sum(total_fee) fee,sum(DEPTOSIT_FEE) fee1, sum(REALITY_FEE) fee2, sum(SELF_FEE+village_fee+FAVOR_FEE-DEPTOSIT_FEE-REALITY_FEE) fee3, count(*) num from zy_costmaster
			   where  costdate >=V_BTIME  and costdate<=V_ETIME  and chargecode=char(V_ALLCHARGER)
			   group by chargecode
          do
		   
		   select name into v_chargecode from DB2INST2.BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(chargecode);
		   
		   select count(*) into v_count from session.tmp_DayFee where �շ�Ա=v_chargecode;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_DayFee set ��Ժҽ�Ʒ����ܶ� = ��Ժҽ�Ʒ����ܶ� + ' || char(fee) || ',
			      			   					  	  ��ԺԤ����=��ԺԤ����+'|| char(fee1) ||',
													  ��Ժ�ֽ��ջ��˿�=��Ժ�ֽ��ջ��˿�+'|| char(fee2) ||',
													  ��Ժ����Ƿ��=��Ժ����Ƿ��+'|| char(fee3) ||',
													  ��Ժ�˴�=��Ժ�˴�+'|| char(num) ||'
						where  �շ�Ա= ''' || v_chargecode || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_DayFee(�շ�Ա,��Ժҽ�Ʒ����ܶ�,��ԺԤ����,��Ժ�ֽ��ջ��˿�,��Ժ����Ƿ��,��Ժ�˴�) values('''|| v_chargecode ||''','|| char(fee) ||','|| char(fee1) ||','|| char(fee2) ||','|| char(fee3) ||','|| char(num) ||')';
		   end if;
		   set ERR_TEXT=sSQL;
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		
		else--�����շ�Ա
		
		--����Ԥ����
	     FOR each_record AS 
			 select
			  chargecode,sum(total_fee) fee, count(*) num from zy_chargelist where  costdate >=V_BTIME  and costdate<=V_ETIME 
			  group by chargecode
          do
		   
		  select name into v_chargecode from DB2INST2.BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(chargecode);
		   
		   select count(*) into v_count from session.tmp_DayFee where �շ�Ա=v_chargecode;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_DayFee set Ԥ���� = Ԥ���� + ' || char(fee) || ', Ԥ���˴�=Ԥ���˴�+'|| char(num) ||' where  �շ�Ա= ''' || v_chargecode || ''' ';		  
		   else
		      set sSQL='insert into session.tmp_DayFee(�շ�Ա,Ԥ����,Ԥ���˴�) values('''|| v_chargecode ||''','|| char(fee) ||','|| char(num) ||')';
		   end if;
		   
		   set ERR_TEXT=sSQL;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  --�����Ժ�������
		   FOR each_record1 AS 
			 select
			   chargecode,sum(total_fee) fee,sum(DEPTOSIT_FEE) fee1, sum(REALITY_FEE) fee2, sum(SELF_FEE+village_fee+FAVOR_FEE-DEPTOSIT_FEE-REALITY_FEE) fee3, count(*) num from zy_costmaster
			   where  costdate >=V_BTIME  and costdate<=V_ETIME 
			   group by chargecode
          do
		   
		  select name into v_chargecode from DB2INST2.BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(chargecode);
		   
		   select count(*) into v_count from session.tmp_DayFee where �շ�Ա=v_chargecode;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_DayFee set ��Ժҽ�Ʒ����ܶ� = ��Ժҽ�Ʒ����ܶ� + ' || char(fee) || ',
			      			   					  	  ��ԺԤ����=��ԺԤ����+'|| char(fee1) ||',
													  ��Ժ�ֽ��ջ��˿�=��Ժ�ֽ��ջ��˿�+'|| char(fee2) ||',
													  ��Ժ����Ƿ��=��Ժ����Ƿ��+'|| char(fee3) ||',
													  ��Ժ�˴�=��Ժ�˴�+'|| char(num) ||'
						where  �շ�Ա= ''' || v_chargecode || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_DayFee(�շ�Ա,��Ժҽ�Ʒ����ܶ�,��ԺԤ����,��Ժ�ֽ��ջ��˿�,��Ժ����Ƿ��,��Ժ�˴�) values('''|| v_chargecode ||''','|| char(fee) ||','|| char(fee1) ||','|| char(fee2) ||','|| char(fee3) ||','|| char(num) ||')';
		   end if;
		   set ERR_TEXT=sSQL;
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  
		end if;
		
		
		  
		  
		--���ºϼ�
	    update session.tmp_DayFee set 
		�ϼ�=(Ԥ���� + ��Ժ�ֽ��ջ��˿�);
        
		insert into session.tmp_DayFee(�շ�Ա,Ԥ����,Ԥ���˴�,��Ժҽ�Ʒ����ܶ�,��ԺԤ����,��Ժ�ֽ��ջ��˿�,��Ժ����Ƿ��,��Ժ�˴�,�ϼ�) 
			   		select '�ϼ�' as �շ�Ա,sum(Ԥ����) as Ԥ����,sum(Ԥ���˴�) as Ԥ���˴�,sum(��Ժҽ�Ʒ����ܶ�) as ��Ժҽ�Ʒ����ܶ�,
					sum(��ԺԤ����) as ��ԺԤ����,sum(��Ժ�ֽ��ջ��˿�) as ��Ժ�ֽ��ջ��˿�,sum(��Ժ����Ƿ��) as ��Ժ����Ƿ��,sum(��Ժ�˴�) as ��Ժ�˴�,sum(�ϼ�) as �ϼ�
				    from session.tmp_DayFee;
   
  end p2;
  begin
   declare cur_01 cursor with return for
     select * from session.tmp_DayFee;
   open cur_01;
  end;
end p1;

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_ZY_FEEMXRPT"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP, 
  IN "V_TYPE" INTEGER, 
  IN "V_ZYDEPT" INTEGER, 
  OUT "ERR_CODE" INTEGER, 
  OUT "ERR_TEXT" CHARACTER(100)
 ) 
  SPECIFIC "DB2INST2"."SQL100906163424000"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  p1: begin  
	 
	declare v_patname varchar(20);--new 
	declare v_presdept varchar(20);
	declare v_presdoc varchar(20);
	declare v_itemtype varchar(20);
	declare v_count int;
	Declare   sSQL   varchar(1000);  
	 
 
declare global temporary table tmp_kjxmFee(
	���� varchar(20),
	ҽ�� varchar(20),
	�������� varchar(20),--new 
	patlist_id integer DEFAULT 0,--new 
	�ϼ� decimal(18,2) DEFAULT 0,
    ��ҩ decimal(18,2) DEFAULT 0,
	�г�ҩ decimal(18,2) DEFAULT 0, 
	��ҩ decimal(18,2) DEFAULT 0, 
	ҩƷ����С�� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	CT decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	A�� decimal(18,2) DEFAULT 0,
	B�� decimal(18,2) DEFAULT 0,
	�ʳ� decimal(18,2) DEFAULT 0,
	θ�� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	�ؼ�����С�� decimal(18,2) DEFAULT 0,
	���� INTEGER DEFAULT 0,--new 
	��λ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��Ѫ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��ҩ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��ѹ�� decimal(18,2) DEFAULT 0,
	��ʯ decimal(18,2) DEFAULT 0,
	ˮ�� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	�˴Ź��� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	ҽ������С�� decimal(18,2) DEFAULT 0
	      )
     not logged on commit preserve rows with replace in usertemp1;
	 
	  
	 
	
	
	p2: begin
	 if(V_TYPE=1) then
	
	     FOR each_record AS 
			 select
			  patid,patlistid, presdeptcode,presdoccode,itemtype,sum(tolal_fee) fee,date(costdate) costdate
		       from DB2INST2.ZY_PRESORDER where charge_flag=1 and costdate>=V_BTIME  and costdate<=V_ETIME 
		       group by presdeptcode,presdoccode,patid,patlistid,itemtype,date(costdate)
			   order by presdeptcode,presdoccode,patid,patlistid
          do
		  
		   select a.patname into v_patname from patientinfo a where a.patid=each_record.patid;
           --set		   v_patname='aa'; 
		  
		   if(presdeptcode='' or presdeptcode='0') then
		   set v_presdept='δָ��';
		   else
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   end if;
		   if(presdoccode='' or presdoccode='0') then
		   set v_presdoc='δָ��';
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   end if;
		   
		   select item_name into v_itemtype from base_stat_zykj where code=(select zykj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc and patlist_id=patlistid;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' and patlist_id= '||char(patlistid)||' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,��������,patlist_id,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','''||v_patname||''','||char(patlistid)||','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  
    else
	
	FOR each_record AS 
			 select
			  patid,patlistid, presdeptcode,presdoccode,itemtype,sum(tolal_fee) fee,date(costdate) costdate
		       from DB2INST2.ZY_PRESORDER where charge_flag=1 and costdate>=V_BTIME  and costdate<=V_ETIME  and presdeptcode =char(V_ZYDEPT)
		       group by presdeptcode,presdoccode,patid,patlistid,itemtype,date(costdate)
			   order by presdeptcode,presdoccode,patid,patlistid
          do
		  
		   select a.patname into v_patname from patientinfo a where a.patid=each_record.patid;
           --set		   v_patname='aa'; 
		  
		   if(presdeptcode='' or presdeptcode='0') then
		   set v_presdept='δָ��';
		   else
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   end if;
		   if(presdoccode='' or presdoccode='0') then
		   set v_presdoc='δָ��';
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   end if;
		   
		   select item_name into v_itemtype from base_stat_zykj where code=(select zykj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc and patlist_id=patlistid;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' and patlist_id= '||char(patlistid)||' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,��������,patlist_id,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','''||v_patname||''','||char(patlistid)||','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
	
	end if;
		  
		 -- ����
		 update session.tmp_kjxmFee  set 
		 ����=(select 
					 case 
						when pattype in ('1','2') then  
						current date - curedate
						when pattype in('3','4','5') then
						outdate-curedate
						else 0 end 
						from zy_patlist where zy_patlist.patlistid= patlist_id) ;
		 
		  
	    update session.tmp_kjxmFee set 
		ҩƷ����С��=(��ҩ + �г�ҩ + ��ҩ),
		�ؼ�����С��=(���� + CT + ���� + A�� + B�� + �ʳ� + θ�� + ������),
		ҽ������С��=(��λ + ���� + ��� + ���� + ��Ѫ + ���� + ���� + ��ҩ + ���� + ���� + ���� + ���� + ��ѹ�� + ��ʯ + ˮ�� + ������ + �˴Ź��� + ����);
		
		update session.tmp_kjxmFee set �ϼ�=(ҩƷ����С�� + �ؼ�����С�� + ҽ������С��);
		
		insert into session.tmp_kjxmFee
		 select '�ϼ�' as ����,'' as ҽ��,'' as ��������, 0 as patlist_id, sum(�ϼ�) as �ϼ�,sum(��ҩ) as ��ҩ,sum(�г�ҩ) as �г�ҩ,sum(��ҩ) as ��ҩ, sum(ҩƷ����С��) as ҩƷ����С��,
		 sum(����) as ����, sum(CT) as CT ,sum(����) as ����, sum(A��) as A��,sum(B��) as B��,sum(�ʳ�) as �ʳ�,sum(θ��) as θ��,sum(������) as ������,sum(�ؼ�����С��) as �ؼ�����С��,
		 sum(����) as ����,
		 sum(��λ) as ��λ, sum(����) as ����, sum(���) as ���,sum(����) as ����,sum(��Ѫ) as ��Ѫ,sum(����) as ����,sum(����) as ����, sum(��ҩ) as ��ҩ, sum(����) as ����,sum(����) as ����,sum(����) as ����,sum(����) as ����,sum(��ѹ��) as ��ѹ��,sum(��ʯ) as ��ʯ,sum(ˮ��) as ˮ��,sum(������) as ������,sum(�˴Ź���) as �˴Ź���,sum(����) as ���� ,sum(ҽ������С��) as ҽ������С��
		 from session.tmp_kjxmFee;
   
   
   
  end p2;
  begin
   declare cur_01 cursor with return for
     select * from session.tmp_kjxmFee;
   open cur_01;
  end;
end p1;

SET SCHEMA DB2INST2;

SET CURRENT PATH = "SYSIBM","SYSFUN","SYSPROC","SYSIBMADM","DB2INST2";

CREATE PROCEDURE "DB2INST2"."SP_ZY_FEERPT"
 (IN "V_BTIME" TIMESTAMP, 
  IN "V_ETIME" TIMESTAMP, 
  IN "V_TYPE" INTEGER, 
  IN "V_ZYDEPT" INTEGER, 
  OUT "ERR_CODE" INTEGER, 
  OUT "ERR_TEXT" CHARACTER(100)
 ) 
  SPECIFIC "DB2INST2"."SQL100903162820700"
  LANGUAGE SQL
  NOT DETERMINISTIC
  CALLED ON NULL INPUT
  EXTERNAL ACTION
  OLD SAVEPOINT LEVEL
  MODIFIES SQL DATA
  INHERIT SPECIAL REGISTERS
  p1: begin     
	
	declare v_presdept varchar(20);
	declare v_presdoc varchar(20); 
	declare v_itemtype varchar(20);
	declare v_count int; 
	Declare   sSQL   varchar(1000);   
	
 
declare global temporary table tmp_kjxmFee(
	���� varchar(20),
	ҽ�� varchar(20),
	�ϼ� decimal(18,2) DEFAULT 0,
    ��ҩ decimal(18,2) DEFAULT 0,
	�г�ҩ decimal(18,2) DEFAULT 0, 
	��ҩ decimal(18,2) DEFAULT 0,
	ҩƷ����С�� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	CT decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	A�� decimal(18,2) DEFAULT 0,
	B�� decimal(18,2) DEFAULT 0,
	�ʳ� decimal(18,2) DEFAULT 0,
	θ�� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	�ؼ�����С�� decimal(18,2) DEFAULT 0,
	��λ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��Ѫ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��ҩ decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0, 
	���� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	��ѹ�� decimal(18,2) DEFAULT 0,
	��ʯ decimal(18,2) DEFAULT 0,
	ˮ�� decimal(18,2) DEFAULT 0,
	������ decimal(18,2) DEFAULT 0,
	�˴Ź��� decimal(18,2) DEFAULT 0,
	���� decimal(18,2) DEFAULT 0,
	ҽ������С�� decimal(18,2) DEFAULT 0
	      )
     not logged on commit preserve rows with replace in usertemp1;
	 
	  
	 
	
	
	p2: begin
	    if(V_TYPE=1)
		then
	     FOR each_record AS 
			 select
			   presdeptcode,presdoccode,itemtype,sum(tolal_fee) fee,date(costdate) costdate
		       from DB2INST2.ZY_PRESORDER where charge_flag=1 and costdate>=V_BTIME  and costdate<=V_ETIME 
		       group by presdeptcode,presdoccode,itemtype,date(costdate)
			   order by  presdeptcode,presdoccode		
          do
		   if(presdeptcode='' or presdeptcode='0') then
		   set v_presdept='δָ��';		
		   else
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   end if;
		   if(presdoccode='' or presdoccode='0') then
		   set v_presdoc='δָ��';		
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   end if;
		   
		   select item_name into v_itemtype from base_stat_zykj where code=(select zykj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		 else
		   FOR each_record AS 
			 select
			   presdeptcode,presdoccode,itemtype,sum(tolal_fee) fee,date(costdate) costdate
		       from DB2INST2.ZY_PRESORDER where charge_flag=1 and costdate>=V_BTIME  and costdate<=V_ETIME  and int(presdeptcode)=V_ZYDEPT  
		       group by presdeptcode,presdoccode,itemtype,date(costdate)
			   order by  presdeptcode,presdoccode		
          do
		   if(presdeptcode='' or presdeptcode='0' ) then
		   set v_presdept='δָ��';
		   else
		   select name into v_presdept from BASE_DEPT_PROPERTY where dept_id=int(presdeptcode);
		   end if;
		   if(presdoccode='' or presdoccode='0') then
		   set v_presdoc='δָ��';
		   else
		   select name into v_presdoc from BASE_EMPLOYEE_PROPERTY where EMPLOYEE_ID=int(presdoccode);
		   end if;
		   
		   select item_name into v_itemtype from base_stat_zykj where code=(select zykj_code from base_stat_item where code=itemtype);
		   
		   select count(*) into v_count from session.tmp_kjxmFee where ����=v_presdept and ҽ��=v_presdoc;
		   
		   if(v_count>0) then
		      set sSQL='update session.tmp_kjxmFee set ' || v_itemtype || ' = ' || v_itemtype || '+ ' || char(fee) || ' where  ���� = ''' || v_presdept || ''' and ҽ��= ''' || v_presdoc || ''' ';		  
			    
		   else
		      set sSQL='insert into session.tmp_kjxmFee(����,ҽ��,' || v_itemtype || ') values('''|| v_presdept ||''','''|| v_presdoc ||''','|| char(fee) ||')';
		   end if;
		   
		      prepare   s1   from   sSql;   
              execute   s1;
		  end for;
		  end if;
	    update session.tmp_kjxmFee set 
		ҩƷ����С��=(��ҩ + �г�ҩ + ��ҩ),
		�ؼ�����С��=(���� + CT + ���� + A�� + B�� + �ʳ� + θ�� + ������),
		ҽ������С��=(��λ + ���� + ��� + ���� + ��Ѫ + ���� + ���� + ��ҩ + ���� + ���� + ���� + ���� + ��ѹ�� + ��ʯ + ˮ�� + ������ + �˴Ź���+����);
		
		update session.tmp_kjxmFee set �ϼ�=(ҩƷ����С�� + �ؼ�����С�� + ҽ������С��);
		
   insert into session.tmp_kjxmFee
		 select '�ϼ�' as ����,'' as ҽ��, sum(�ϼ�) as �ϼ�,sum(��ҩ) as ��ҩ,sum(�г�ҩ) as �г�ҩ,sum(��ҩ) as ��ҩ, sum(ҩƷ����С��) as ҩƷ����С��,
		 sum(����) as ����, sum(CT) as CT ,sum(����) as ����, sum(A��) as A��,sum(B��) as B��,sum(�ʳ�) as �ʳ�,sum(θ��) as θ��,sum(������) as ������,sum(�ؼ�����С��) as �ؼ�����С��,
		 sum(��λ) as ��λ, sum(����) as ����, sum(���) as ���,sum(����) as ����,sum(��Ѫ) as ��Ѫ,sum(����) as ����,sum(����) as ����, sum(��ҩ) as ��ҩ, sum(����) as ����,sum(����) as ����,sum(����) as ����,sum(����) as ����,sum(��ѹ��) as ��ѹ��,sum(��ʯ) as ��ʯ,sum(ˮ��) as ˮ��,sum(������) as ������,sum(�˴Ź���) as �˴Ź���,sum(����) as ���� ,sum(ҽ������С��) as ҽ������С��
		 from session.tmp_kjxmFee;
   
   
   
  end p2;
  begin
   declare cur_01 cursor with return for
     select * from session.tmp_kjxmFee;
   open cur_01;
  end;
end p1;



-- End of generated script for 220.128.5.3-DB2-LLZYDB (db2inst2)