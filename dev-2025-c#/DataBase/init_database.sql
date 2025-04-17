SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;

ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: tbl_user; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_user (
    id character varying(255) NOT NULL,
    email character varying(255),
    enabled boolean NOT NULL,
    first_name character varying(255),
    job_title character varying(255),
    last_name character varying(255),
    middle_name character varying(255),
    password character varying(255),
    telephone character varying(255),
    username character varying(255),
    profile_image_id character varying(255),
    language_id character varying(255),
    tenant_id character varying(255),
    legacy_id bigint,
    role character varying(255) NOT NULL,
    first_access boolean,
    calendar_view character varying(255) NOT NULL
);

SELECT*FROM tbl_user;
ALTER TABLE public.tbl_user OWNER TO postgres;

--
-- Data for Name: tbl_user; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_user 
(id, email, enabled, first_name, job_title, last_name, middle_name, password, telephone, username, profile_image_id, language_id, tenant_id, legacy_id, role, first_access, calendar_view) 
VALUES 
('3c3f438e-ec3a-4c17-a23d-580975de8ee6', 'assessment@letshare-test.com', true, 'Esther', 'Head of Customer Service', 'de Jong', NULL, '$2a$13$LCVcpVzUSYu76WFy3L0AB.FqJ9DYJXDksFAsKa5asaTgNex4NCKvi', NULL, NULL, 'e3d7bb5b-4377-4ac5-9ce4-33cba7f16459', '5f9341e4-f59f-41e6-bb67-0ff989f4a6da', '7d2aa378-9a1b-4a2f-80f3-9d9be6234a3f', NULL, 'ADM', false, 'MONTH');


--
-- Name: tbl_user tbl_user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_user
    ADD CONSTRAINT tbl_user_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--


INSERT INTO tbl_user (
    id, email, password, first_name, middle_name, last_name,
    telephone, job_title, first_access,
    enabled, username, role, calendar_view
) VALUES (
    gen_random_uuid()::text,
    'teste@dev.com',
    '$2a$11$7ih8XqD8Cz0T2xwSlZpKquWmTnqeoF7AZmLwXwDfULbN27EbrZqHK',
    'Lana', '', 'Dev',
    '11999999999', 'Desenvolvedora', true,
    true, 'lana.dev', 'user', false
);