CREATE DATABASE gisdb
  WITH ENCODING='UTF8'
       TEMPLATE=postgis_21_sample
       CONNECTION LIMIT=-1;

\c gisdb;

CREATE TABLE changeset_tags (
    id BIGINT NOT NULL, -- references changesets(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE changesets (
    id BIGINT NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    created_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    min_lat INTEGER,
    max_lat INTEGER,
    min_lon INTEGER,
    max_lon INTEGER,
    closed_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    num_changes INTEGER DEFAULT 0 NOT NULL
);

CREATE TABLE current_node_tags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_nodes(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE current_nodes (
    id BIGINT NOT NULL, -- autoincrement primary key
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    visible BOOLEAN NOT NULL,
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    tile BIGINT NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE node_tags (
    id BIGINT NOT NULL, -- primary key part 1/3; references nodes(id,version) part 1/2
    version BIGINT NOT NULL, -- primary key part 2/3; references nodes(id,version) part 2/2
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE nodes (
    id BIGINT NOT NULL, -- primary key part 1/2
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    visible BOOLEAN NOT NULL,
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    tile BIGINT NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/2
);

CREATE TABLE current_way_nodes (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_ways(id)
    node_id BIGINT NOT NULL, -- references current_nodes(id)
    sequence_id BIGINT NOT NULL -- primary key part 2/2
);
 
CREATE TABLE current_way_tags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_ways(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE current_ways (
    id BIGINT NOT NULL, -- autoincrement primary key
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    visible BOOLEAN NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE way_nodes (
    id BIGINT NOT NULL, -- primary key part 1/3; references ways(id, version) part 1/2
    node_id BIGINT NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/3; references ways(id, version) part 2/2
    sequence_id BIGINT NOT NULL -- primary key part 3/3
);
 
CREATE TABLE way_tags (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/3; references ways(id, version) part 1/2
    k CHARACTER VARYING(255) NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/3 -- references ways(id, version) part 2/2
);
 
CREATE TABLE ways (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/2
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/2
    visible BOOLEAN DEFAULT TRUE NOT NULL
);

CREATE TABLE current_relation_members (
    id BIGINT NOT NULL, -- primary key part 1/5; references current_relations(id)
    member_type BIGINT NOT NULL, -- primary key part 2/5
    member_id BIGINT NOT NULL, -- primary key part 3/5
    member_role CHARACTER VARYING(255) NOT NULL, -- primary key part 4/5
    sequence_id INTEGER DEFAULT 0 NOT NULL -- primary key part 5/5
);
 
CREATE TABLE current_relation_tags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_relations(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, --primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE current_relations (
    id BIGINT NOT NULL, -- autoincrement primary key
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    visible BOOLEAN NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE relation_members (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/5; references relations(id, version) part 1/2
    member_type BIGINT NOT NULL, -- primary key part 3/6
    member_id BIGINT NOT NULL, -- primary key part 4/6
    member_role CHARACTER VARYING(255) NOT NULL, -- primary key part 5/6
    version BIGINT DEFAULT 0 NOT NULL, -- primary key part 2/6; references relations(id, version) part 2/2
    sequence_id INTEGER DEFAULT 0 NOT NULL -- primary key part 6/6
);
 
CREATE TABLE relation_tags (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/3; references relations(id, version) part 1/2
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/3; references relations(id, version) part 2/2
);
 
CREATE TABLE relations (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/2
    changeset_id BIGINT NOT NULL, -- references changesets(id)
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/2
    visible BOOLEAN DEFAULT TRUE NOT NULL
);

CREATE TABLE countries (
    id INTEGER NOT NULL, -- autoincrement primary key
    code CHARACTER VARYING(2) NOT NULL,
    min_lat DOUBLE PRECISION NOT NULL,
    max_lat DOUBLE PRECISION NOT NULL,
    min_lon DOUBLE PRECISION NOT NULL,
    max_lon DOUBLE PRECISION NOT NULL
);

CREATE TABLE gps_points (
    altitude DOUBLE PRECISION,
    trackid INTEGER NOT NULL,
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    gpx_id BIGINT NOT NULL, -- references gpx_files(id)
    "timestamp" TIMESTAMP WITHOUT TIME zone,
    tile BIGINT
);
 
CREATE TABLE gpx_file_tags (
    gpx_id BIGINT DEFAULT 0 NOT NULL, -- references gpx_files(id)
    tag CHARACTER VARYING(255) NOT NULL,
    id BIGINT NOT NULL -- autoincrement primary key
);
 
CREATE TABLE gpx_files (
    id BIGINT NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    visible BOOLEAN DEFAULT TRUE NOT NULL,
    name CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    SIZE BIGINT,
    latitude DOUBLE PRECISION,
    longitude DOUBLE PRECISION,
    "timestamp" TIMESTAMP WITHOUT TIME zone NOT NULL,
    description CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    inserted BOOLEAN NOT NULL,
    visibility BIGINT DEFAULT 1 NOT NULL
);

CREATE TABLE acls (
    id INTEGER NOT NULL, -- autoincrement primary key
    address inet NOT NULL,
    netmask inet NOT NULL,
    k CHARACTER VARYING(255) NOT NULL,
    v CHARACTER VARYING(255)
);
 
CREATE TABLE client_applications (
    id INTEGER NOT NULL, -- autoincrement primary key
    name CHARACTER VARYING(255),
    url CHARACTER VARYING(255),
    support_url CHARACTER VARYING(255),
    callback_url CHARACTER VARYING(255),
    KEY CHARACTER VARYING(50),
    secret CHARACTER VARYING(50),
    user_id INTEGER, -- references users(id)
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone,
    allow_read_prefs BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_prefs BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_diary BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_api BOOLEAN DEFAULT FALSE NOT NULL,
    allow_read_gpx BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_gpx BOOLEAN DEFAULT FALSE NOT NULL
);
 
CREATE TABLE diary_comments (
    id BIGINT NOT NULL, --autoincrement primary key
    diary_entry_id BIGINT NOT NULL, -- references diary_entries(id)
    user_id BIGINT NOT NULL,
    body text NOT NULL,
    created_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    updated_at TIMESTAMP WITHOUT TIME zone NOT NULL
);
 
CREATE TABLE diary_entries (
    id BIGINT NOT NULL, --autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    title CHARACTER VARYING(255) NOT NULL,
    body text NOT NULL,
    created_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    updated_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    latitude DOUBLE PRECISION,
    longitude DOUBLE PRECISION,
    language_code CHARACTER VARYING(255) DEFAULT 'en'::CHARACTER VARYING NOT NULL -- references languages(code)
);
 
CREATE TABLE friends (
    id BIGINT NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    friend_user_id BIGINT NOT NULL -- references users(id)
);
 
CREATE TABLE languages (
    code CHARACTER VARYING(255) NOT NULL, -- primary key
    english_name CHARACTER VARYING(255) NOT NULL,
    native_name CHARACTER VARYING(255)
);
 
CREATE TABLE messages (
    id BIGINT NOT NULL, -- autoincrement primary key
    from_user_id BIGINT NOT NULL, -- references users(id)
    title CHARACTER VARYING(255) NOT NULL,
    body text NOT NULL,
    sent_on TIMESTAMP WITHOUT TIME zone NOT NULL,
    message_read BOOLEAN DEFAULT FALSE NOT NULL,
    to_user_id BIGINT NOT NULL, -- references users(id)
    to_user_visible BOOLEAN DEFAULT TRUE NOT NULL,
    from_user_visible BOOLEAN DEFAULT TRUE NOT NULL
);
 
CREATE TABLE oauth_nonces (
    id INTEGER NOT NULL, -- autoincrement primary key
    nonce CHARACTER VARYING(255),
    "timestamp" INTEGER,
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE oauth_tokens (
    id INTEGER NOT NULL, -- autoincrement primary key
    user_id INTEGER, -- references users(id)
    TYPE CHARACTER VARYING(20),
    client_application_id INTEGER, -- references client_applications(id)
    token CHARACTER VARYING(50),
    secret CHARACTER VARYING(50),
    authorized_at TIMESTAMP WITHOUT TIME zone,
    invalidated_at TIMESTAMP WITHOUT TIME zone,
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone,
    allow_read_prefs BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_prefs BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_diary BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_api BOOLEAN DEFAULT FALSE NOT NULL,
    allow_read_gpx BOOLEAN DEFAULT FALSE NOT NULL,
    allow_write_gpx BOOLEAN DEFAULT FALSE NOT NULL
);
 
CREATE TABLE schema_migrations (
    version CHARACTER VARYING(255) NOT NULL
);
 
CREATE TABLE sessions (
    id INTEGER NOT NULL, -- autoincrement primary key
    session_id CHARACTER VARYING(255),
    DATA text,
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE user_blocks (
    id INTEGER NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    creator_id BIGINT NOT NULL, -- references users(id)
    reason text NOT NULL,
    ends_at TIMESTAMP WITHOUT TIME zone NOT NULL,
    needs_view BOOLEAN DEFAULT FALSE NOT NULL,
    revoker_id BIGINT, -- references users(id)
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE user_preferences (
    user_id BIGINT NOT NULL, -- primary key part 1/2; references users(id)
    k CHARACTER VARYING(255) NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) NOT NULL
);
 
CREATE TABLE user_roles (
    id INTEGER NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    created_at TIMESTAMP WITHOUT TIME zone,
    updated_at TIMESTAMP WITHOUT TIME zone,
    ROLE BIGINT NOT NULL,
    granter_id BIGINT NOT NULL -- references users(id)
);
 
CREATE TABLE user_tokens (
    id BIGINT NOT NULL, -- autoincrement primary key
    user_id BIGINT NOT NULL, -- references users(id)
    token CHARACTER VARYING(255) NOT NULL,
    expiry TIMESTAMP WITHOUT TIME zone NOT NULL,
    referer text
);
 
CREATE TABLE users (
    email CHARACTER VARYING(255) NOT NULL,
    id BIGINT NOT NULL, -- autoincrement primary key
    active INTEGER DEFAULT 0 NOT NULL,
    pass_crypt CHARACTER VARYING(255) NOT NULL,
    creation_time TIMESTAMP WITHOUT TIME zone NOT NULL,
    display_name CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    data_public BOOLEAN DEFAULT FALSE NOT NULL,
    description text DEFAULT ''::text NOT NULL,
    home_lat DOUBLE PRECISION,
    home_lon DOUBLE PRECISION,
    home_zoom SMALLINT DEFAULT 3,
    nearby INTEGER DEFAULT 50,
    pass_salt CHARACTER VARYING(255),
    image text,
    email_valid BOOLEAN DEFAULT FALSE NOT NULL,
    new_email CHARACTER VARYING(255),
    visible BOOLEAN DEFAULT TRUE NOT NULL,
    creation_ip CHARACTER VARYING(255),
    languages CHARACTER VARYING(255)
);

Create TABLE conststring(
    id BIGINT NOT NULL,
	t CHARACTER VARYING(255) NOT NULL,
    k CHARACTER VARYING(255) NOT NULL,
    v CHARACTER VARYING(255)
);

ALTER TABLE ONLY acls
    ADD CONSTRAINT acls_pkey PRIMARY KEY (id);
ALTER TABLE ONLY changesets
    ADD CONSTRAINT changesets_pkey PRIMARY KEY (id);
ALTER TABLE ONLY client_applications
    ADD CONSTRAINT client_applications_pkey PRIMARY KEY (id);
ALTER TABLE ONLY countries
    ADD CONSTRAINT countries_pkey PRIMARY KEY (id);
ALTER TABLE ONLY current_node_tags
    ADD CONSTRAINT current_node_tags_pkey PRIMARY KEY (id, k);
ALTER TABLE ONLY current_nodes
    ADD CONSTRAINT current_nodes_pkey1 PRIMARY KEY (id);
ALTER TABLE ONLY current_relation_members
    ADD CONSTRAINT current_relation_members_pkey PRIMARY KEY (id, member_type, member_id, member_role, sequence_id);
ALTER TABLE ONLY current_relation_tags
    ADD CONSTRAINT current_relation_tags_pkey PRIMARY KEY (id, k);
ALTER TABLE ONLY current_relations
    ADD CONSTRAINT current_relations_pkey PRIMARY KEY (id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_pkey PRIMARY KEY (id, sequence_id);
ALTER TABLE ONLY current_way_tags
    ADD CONSTRAINT current_way_tags_pkey PRIMARY KEY (id, k);
ALTER TABLE ONLY current_ways
    ADD CONSTRAINT current_ways_pkey PRIMARY KEY (id);
ALTER TABLE ONLY diary_comments
    ADD CONSTRAINT diary_comments_pkey PRIMARY KEY (id);
ALTER TABLE ONLY diary_entries
    ADD CONSTRAINT diary_entries_pkey PRIMARY KEY (id);
ALTER TABLE ONLY friends
    ADD CONSTRAINT friends_pkey PRIMARY KEY (id);
ALTER TABLE ONLY gpx_file_tags
    ADD CONSTRAINT gpx_file_tags_pkey PRIMARY KEY (id);
ALTER TABLE ONLY gpx_files
    ADD CONSTRAINT gpx_files_pkey PRIMARY KEY (id);
ALTER TABLE ONLY languages
    ADD CONSTRAINT languages_pkey PRIMARY KEY (code);
ALTER TABLE ONLY messages
    ADD CONSTRAINT messages_pkey PRIMARY KEY (id);
ALTER TABLE ONLY node_tags
    ADD CONSTRAINT node_tags_pkey PRIMARY KEY (id, version, k);
ALTER TABLE ONLY nodes
    ADD CONSTRAINT nodes_pkey PRIMARY KEY (id, version);
ALTER TABLE ONLY oauth_nonces
    ADD CONSTRAINT oauth_nonces_pkey PRIMARY KEY (id);
ALTER TABLE ONLY oauth_tokens
    ADD CONSTRAINT oauth_tokens_pkey PRIMARY KEY (id);
ALTER TABLE ONLY relation_members
    ADD CONSTRAINT relation_members_pkey PRIMARY KEY (id, version, member_type, member_id, member_role, sequence_id);
ALTER TABLE ONLY relation_tags
    ADD CONSTRAINT relation_tags_pkey PRIMARY KEY (id, version, k);
ALTER TABLE ONLY relations
    ADD CONSTRAINT relations_pkey PRIMARY KEY (id, version);
ALTER TABLE ONLY sessions
    ADD CONSTRAINT sessions_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_preferences
    ADD CONSTRAINT user_preferences_pkey PRIMARY KEY (user_id, k);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_tokens
    ADD CONSTRAINT user_tokens_pkey PRIMARY KEY (id);
ALTER TABLE ONLY users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
ALTER TABLE ONLY way_nodes
    ADD CONSTRAINT way_nodes_pkey PRIMARY KEY (id, version, sequence_id);
ALTER TABLE ONLY way_tags
    ADD CONSTRAINT way_tags_pkey PRIMARY KEY (id, version, k);
ALTER TABLE ONLY ways
    ADD CONSTRAINT ways_pkey PRIMARY KEY (id, version);
ALTER TABLE ONLY conststring
    ADD CONSTRAINT conststring_pkey PRIMARY KEY (id);

ALTER TABLE ONLY changeset_tags
    ADD CONSTRAINT changeset_tags_id_fkey FOREIGN KEY (id) REFERENCES changesets(id);
ALTER TABLE ONLY changesets
    ADD CONSTRAINT changesets_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY client_applications
    ADD CONSTRAINT client_applications_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY current_node_tags
    ADD CONSTRAINT current_node_tags_id_fkey FOREIGN KEY (id) REFERENCES current_nodes(id);
ALTER TABLE ONLY current_nodes
    ADD CONSTRAINT current_nodes_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);
ALTER TABLE ONLY current_relation_members
    ADD CONSTRAINT current_relation_members_id_fkey FOREIGN KEY (id) REFERENCES current_relations(id);
ALTER TABLE ONLY current_relation_tags
    ADD CONSTRAINT current_relation_tags_id_fkey FOREIGN KEY (id) REFERENCES current_relations(id);
ALTER TABLE ONLY current_relations
    ADD CONSTRAINT current_relations_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_id_fkey FOREIGN KEY (id) REFERENCES current_ways(id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_node_id_fkey FOREIGN KEY (node_id) REFERENCES current_nodes(id);
ALTER TABLE ONLY current_way_tags
    ADD CONSTRAINT current_way_tags_id_fkey FOREIGN KEY (id) REFERENCES current_ways(id);
ALTER TABLE ONLY current_ways
    ADD CONSTRAINT current_ways_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);
ALTER TABLE ONLY diary_comments
    ADD CONSTRAINT diary_comments_diary_entry_id_fkey FOREIGN KEY (diary_entry_id) REFERENCES diary_entries(id);
ALTER TABLE ONLY diary_comments
    ADD CONSTRAINT diary_comments_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY diary_entries
    ADD CONSTRAINT diary_entries_language_code_fkey FOREIGN KEY (language_code) REFERENCES languages(code);
ALTER TABLE ONLY diary_entries
    ADD CONSTRAINT diary_entries_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY friends
    ADD CONSTRAINT friends_friend_user_id_fkey FOREIGN KEY (friend_user_id) REFERENCES users(id);
ALTER TABLE ONLY friends
    ADD CONSTRAINT friends_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY gps_points
    ADD CONSTRAINT gps_points_gpx_id_fkey FOREIGN KEY (gpx_id) REFERENCES gpx_files(id);
ALTER TABLE ONLY gpx_file_tags
    ADD CONSTRAINT gpx_file_tags_gpx_id_fkey FOREIGN KEY (gpx_id) REFERENCES gpx_files(id);
ALTER TABLE ONLY gpx_files
    ADD CONSTRAINT gpx_files_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY messages
    ADD CONSTRAINT messages_from_user_id_fkey FOREIGN KEY (from_user_id) REFERENCES users(id);
ALTER TABLE ONLY messages
    ADD CONSTRAINT messages_to_user_id_fkey FOREIGN KEY (to_user_id) REFERENCES users(id);
ALTER TABLE ONLY node_tags
    ADD CONSTRAINT node_tags_id_fkey FOREIGN KEY (id, version) REFERENCES nodes(id, version);
ALTER TABLE ONLY nodes
    ADD CONSTRAINT nodes_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);
ALTER TABLE ONLY oauth_tokens
    ADD CONSTRAINT oauth_tokens_client_application_id_fkey FOREIGN KEY (client_application_id) REFERENCES client_applications(id);
ALTER TABLE ONLY oauth_tokens
    ADD CONSTRAINT oauth_tokens_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY relation_members
    ADD CONSTRAINT relation_members_id_fkey FOREIGN KEY (id, version) REFERENCES relations(id, version);
ALTER TABLE ONLY relation_tags
    ADD CONSTRAINT relation_tags_id_fkey FOREIGN KEY (id, version) REFERENCES relations(id, version);
ALTER TABLE ONLY relations
    ADD CONSTRAINT relations_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_moderator_id_fkey FOREIGN KEY (creator_id) REFERENCES users(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_revoker_id_fkey FOREIGN KEY (revoker_id) REFERENCES users(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY user_preferences
    ADD CONSTRAINT user_preferences_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_granter_id_fkey FOREIGN KEY (granter_id) REFERENCES users(id);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY user_tokens
    ADD CONSTRAINT user_tokens_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);
ALTER TABLE ONLY way_nodes
    ADD CONSTRAINT way_nodes_id_fkey FOREIGN KEY (id, version) REFERENCES ways(id, version);
ALTER TABLE ONLY way_tags
    ADD CONSTRAINT way_tags_id_fkey FOREIGN KEY (id, version) REFERENCES ways(id, version);
ALTER TABLE ONLY ways
    ADD CONSTRAINT ways_changeset_id_fkey FOREIGN KEY (changeset_id) REFERENCES changesets(id);

CREATE SEQUENCE acls_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE changesets_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE client_applications_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE countries_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE current_nodes_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE current_relations_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE current_ways_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE diary_comments_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE diary_entries_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE friends_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE gpx_file_tags_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE gpx_files_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE messages_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE oauth_nonces_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE oauth_tokens_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE sessions_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE user_blocks_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE user_roles_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE user_tokens_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
CREATE SEQUENCE users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;

CREATE SEQUENCE conststring_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;
 
ALTER TABLE acls ALTER COLUMN id SET DEFAULT NEXTVAL('acls_id_seq'::regclass);
ALTER TABLE changesets ALTER COLUMN id SET DEFAULT NEXTVAL('changesets_id_seq'::regclass);
ALTER TABLE client_applications ALTER COLUMN id SET DEFAULT NEXTVAL('client_applications_id_seq'::regclass);
ALTER TABLE countries ALTER COLUMN id SET DEFAULT NEXTVAL('countries_id_seq'::regclass);
ALTER TABLE current_nodes ALTER COLUMN id SET DEFAULT NEXTVAL('current_nodes_id_seq'::regclass);
ALTER TABLE current_relations ALTER COLUMN id SET DEFAULT NEXTVAL('current_relations_id_seq'::regclass);
ALTER TABLE current_ways ALTER COLUMN id SET DEFAULT NEXTVAL('current_ways_id_seq'::regclass);
ALTER TABLE diary_comments ALTER COLUMN id SET DEFAULT NEXTVAL('diary_comments_id_seq'::regclass);
ALTER TABLE diary_entries ALTER COLUMN id SET DEFAULT NEXTVAL('diary_entries_id_seq'::regclass);
ALTER TABLE friends ALTER COLUMN id SET DEFAULT NEXTVAL('friends_id_seq'::regclass);
ALTER TABLE gpx_file_tags ALTER COLUMN id SET DEFAULT NEXTVAL('gpx_file_tags_id_seq'::regclass);
ALTER TABLE gpx_files ALTER COLUMN id SET DEFAULT NEXTVAL('gpx_files_id_seq'::regclass);
ALTER TABLE messages ALTER COLUMN id SET DEFAULT NEXTVAL('messages_id_seq'::regclass);
ALTER TABLE oauth_nonces ALTER COLUMN id SET DEFAULT NEXTVAL('oauth_nonces_id_seq'::regclass);
ALTER TABLE oauth_tokens ALTER COLUMN id SET DEFAULT NEXTVAL('oauth_tokens_id_seq'::regclass);
ALTER TABLE sessions ALTER COLUMN id SET DEFAULT NEXTVAL('sessions_id_seq'::regclass);
ALTER TABLE user_blocks ALTER COLUMN id SET DEFAULT NEXTVAL('user_blocks_id_seq'::regclass);
ALTER TABLE user_roles ALTER COLUMN id SET DEFAULT NEXTVAL('user_roles_id_seq'::regclass);
ALTER TABLE user_tokens ALTER COLUMN id SET DEFAULT NEXTVAL('user_tokens_id_seq'::regclass);
ALTER TABLE users ALTER COLUMN id SET DEFAULT NEXTVAL('users_id_seq'::regclass);
ALTER TABLE conststring ALTER COLUMN id SET DEFAULT NEXTVAL('conststring_id_seq'::regclass);

CREATE INDEX acls_k_idx ON acls USING btree (k);
CREATE INDEX changeset_tags_id_idx ON changeset_tags USING btree (id);
--CREATE INDEX changesets_bbox_idx ON changesets USING gist (min_lat, max_lat, min_lon, max_lon);
CREATE INDEX changesets_closed_at_idx ON changesets USING btree (closed_at);
CREATE INDEX changesets_created_at_idx ON changesets USING btree (created_at);
CREATE INDEX changesets_user_id_idx ON changesets USING btree (user_id);
CREATE UNIQUE INDEX countries_code_idx ON countries USING btree (code);
CREATE INDEX current_nodes_tile_idx ON current_nodes USING btree (tile);
CREATE INDEX current_nodes_timestamp_idx ON current_nodes USING btree ("timestamp");
CREATE INDEX current_relation_members_member_idx ON current_relation_members USING btree (member_type, member_id);
CREATE INDEX current_relations_timestamp_idx ON current_relations USING btree ("timestamp");
CREATE INDEX current_way_nodes_node_idx ON current_way_nodes USING btree (node_id);
CREATE INDEX current_ways_timestamp_idx ON current_ways USING btree ("timestamp");
CREATE UNIQUE INDEX diary_comments_entry_id_idx ON diary_comments USING btree (diary_entry_id, id);
CREATE INDEX friends_user_id_idx ON friends USING btree (user_id);
CREATE INDEX gpx_file_tags_gpxid_idx ON gpx_file_tags USING btree (gpx_id);
CREATE INDEX gpx_file_tags_tag_idx ON gpx_file_tags USING btree (tag);
CREATE INDEX gpx_files_timestamp_idx ON gpx_files USING btree ("timestamp");
CREATE INDEX gpx_files_user_id_idx ON gpx_files USING btree (user_id);
CREATE INDEX gpx_files_visible_visibility_idx ON gpx_files USING btree (visible, visibility);
CREATE UNIQUE INDEX index_client_applications_on_key ON client_applications USING btree (KEY);
CREATE UNIQUE INDEX index_oauth_nonces_on_nonce_and_timestamp ON oauth_nonces USING btree (nonce, "timestamp");
CREATE UNIQUE INDEX index_oauth_tokens_on_token ON oauth_tokens USING btree (token);
CREATE INDEX index_user_blocks_on_user_id ON user_blocks USING btree (user_id);
CREATE INDEX messages_from_user_id_idx ON messages USING btree (from_user_id);
CREATE INDEX messages_to_user_id_idx ON messages USING btree (to_user_id);
CREATE INDEX nodes_changeset_id_idx ON nodes USING btree (changeset_id);
CREATE INDEX nodes_tile_idx ON nodes USING btree (tile);
CREATE INDEX nodes_timestamp_idx ON nodes USING btree ("timestamp");
CREATE INDEX points_gpxid_idx ON gps_points USING btree (gpx_id);
CREATE INDEX points_tile_idx ON gps_points USING btree (tile);
CREATE INDEX relation_members_member_idx ON relation_members USING btree (member_type, member_id);
CREATE INDEX relations_changeset_id_idx ON relations USING btree (changeset_id);
CREATE INDEX relations_timestamp_idx ON relations USING btree ("timestamp");
CREATE UNIQUE INDEX sessions_session_id_idx ON sessions USING btree (session_id);
CREATE UNIQUE INDEX unique_schema_migrations ON schema_migrations USING btree (version);
CREATE INDEX user_id_idx ON friends USING btree (friend_user_id);
CREATE UNIQUE INDEX user_roles_id_role_unique ON user_roles USING btree (user_id, ROLE);
CREATE UNIQUE INDEX user_tokens_token_idx ON user_tokens USING btree (token);
CREATE INDEX user_tokens_user_id_idx ON user_tokens USING btree (user_id);
CREATE UNIQUE INDEX users_display_name_idx ON users USING btree (display_name);
CREATE UNIQUE INDEX users_email_idx ON users USING btree (email);
CREATE INDEX way_nodes_node_idx ON way_nodes USING btree (node_id);
CREATE INDEX ways_changeset_id_idx ON ways USING btree (changeset_id);
CREATE INDEX ways_timestamp_idx ON ways USING btree ("timestamp");
