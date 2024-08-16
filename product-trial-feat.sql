PGDMP  ;    '                |           product-trial-feat    16.4    16.4     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16398    product-trial-feat    DATABASE     �   CREATE DATABASE "product-trial-feat" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Austria.1252';
 $   DROP DATABASE "product-trial-feat";
                postgres    false            �            1259    16399    product    TABLE     �  CREATE TABLE public.product (
    id bigint NOT NULL,
    code character varying NOT NULL,
    name character varying NOT NULL,
    description character varying DEFAULT 'Product Description'::character varying NOT NULL,
    image character varying,
    price numeric NOT NULL,
    category character varying NOT NULL,
    quantity numeric NOT NULL,
    "inventoryStatus" character varying NOT NULL,
    rating numeric
);
    DROP TABLE public.product;
       public         heap    postgres    false            �          0    16399    product 
   TABLE DATA           {   COPY public.product (id, code, name, description, image, price, category, quantity, "inventoryStatus", rating) FROM stdin;
    public          postgres    false    215   
	       Q           2606    16408    product pk_unique 
   CONSTRAINT     W   ALTER TABLE ONLY public.product
    ADD CONSTRAINT pk_unique UNIQUE (id) INCLUDE (id);
 ;   ALTER TABLE ONLY public.product DROP CONSTRAINT pk_unique;
       public            postgres    false    215            S           2606    16405    product product_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.product DROP CONSTRAINT product_pkey;
       public            postgres    false    215            �   �  x��Vێ�H}.?@D�0~��&���d,y�(Ҿ4�604�/_�8c�e�7�ut��ԩjH��,إA��,��~�V�����^�ޟ�QuV�Yi! ��|z����n���t����7�/O��X�  `��H����9�>~C��uHީyOM�|�D��"H���gi��{��iW�5k-��_~����dX??$�N�H��oҬn�Y[��1]��)�4��[�:pH���C-�6z���+
����	����u�'x1�W}|�����ˏח�7�!�Y��j��ʼ��l�j��N����{	Eܽ�IV	x�FO�Y�(`�0E2`|}��)�k@�
AǄ�1E���Ҷui��'R�W�!�j_�V��͔�A���ߠ ��X����(�~�;�e����� *3N��4[o��[�CN�W=�W�2h���L��Utϵֶ�A��N��G��C��Nפ��.
�ԅ~n�F�ۭ�7[�t�a�3ۦ���=��#��]�Y�9�lȑ���r;��X��=<��R8�DW�U�$CC�	�C�����.�����0�*B��MDo�3�`����9�\BǙ�6�e6�6�����^����"��r�A�:W*8+X�̶�C�W#���"t,ω�6EL���ӺT}�K�oiM�6RN�����0%P��:��YH[��AVC�q�������S��}�E����
m5���#��}{�~t_�Н1v r��<��2��K�)�Sw��ҙ���Ds����֦���.�� 8�
�q!����7v�㍽���梈��C8);��ë�f���{~7�%H��%M��Ɣ��~ s'�	g�i�P�r\�_e"�o�q�'���<n����_C�����qэ�S��@��Z^	o>�������[�q     