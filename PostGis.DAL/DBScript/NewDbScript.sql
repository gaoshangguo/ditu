CREATE TABLE changesettags (
    id BIGINT NOT NULL, -- references changesets(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE changesets (
    id BIGINT NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    createdat TIMESTAMP WITHOUT TIME zone NOT NULL,
    minlat INTEGER,
    maxlat INTEGER,
    minlon INTEGER,
    maxlon INTEGER,
    closedat TIMESTAMP WITHOUT TIME zone NOT NULL,
    numchanges INTEGER DEFAULT 0 NOT NULL
);

CREATE TABLE currentnodetags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_nodes(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE currentnodes (
    id BIGINT NOT NULL, -- autoincrement primary key
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    changesetid BIGINT NOT NULL, -- references changesets(id)
    visible BOOLEAN NOT NULL,
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    tile BIGINT NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE nodetags (
    id BIGINT NOT NULL, -- primary key part 1/3; references nodes(id,version) part 1/2
    version BIGINT NOT NULL, -- primary key part 2/3; references nodes(id,version) part 2/2
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE nodes (
    id BIGINT NOT NULL, -- primary key part 1/2
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    changesetid BIGINT NOT NULL, -- references changesets(id)
    visible BOOLEAN NOT NULL,
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    tile BIGINT NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/2
);

CREATE TABLE currentwaynodes (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_ways(id)
    nodeid BIGINT NOT NULL, -- references current_nodes(id)
    sequenceid BIGINT NOT NULL -- primary key part 2/2
);
 
CREATE TABLE currentwaytags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_ways(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE currentways (
    id BIGINT NOT NULL, -- autoincrement primary key
    changesetid BIGINT NOT NULL, -- references changesets(id)
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    visible BOOLEAN NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE waynodes (
    id BIGINT NOT NULL, -- primary key part 1/3; references ways(id, version) part 1/2
    nodeid BIGINT NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/3; references ways(id, version) part 2/2
    sequenceid BIGINT NOT NULL -- primary key part 3/3
);
 
CREATE TABLE waytags (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/3; references ways(id, version) part 1/2
    k CHARACTER VARYING(255) NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/3 -- references ways(id, version) part 2/2
);
 
CREATE TABLE ways (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/2
    changesetid BIGINT NOT NULL, -- references changesets(id)
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/2
    visible BOOLEAN DEFAULT TRUE NOT NULL
);

CREATE TABLE currentrelationmembers (
    id BIGINT NOT NULL, -- primary key part 1/5; references current_relations(id)
    membertype BIGINT NOT NULL, -- primary key part 2/5
    memberid BIGINT NOT NULL, -- primary key part 3/5
    memberrole CHARACTER VARYING(255) NOT NULL, -- primary key part 4/5
    sequenceid INTEGER DEFAULT 0 NOT NULL -- primary key part 5/5
);
 
CREATE TABLE currentrelationtags (
    id BIGINT NOT NULL, -- primary key part 1/2; references current_relations(id)
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, --primary key part 2/2
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE currentrelations (
    id BIGINT NOT NULL, -- autoincrement primary key
    changesetid BIGINT NOT NULL, -- references changesets(id)
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    visible BOOLEAN NOT NULL,
    version BIGINT NOT NULL
);
 
CREATE TABLE relationmembers (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/5; references relations(id, version) part 1/2
    membertype BIGINT NOT NULL, -- primary key part 3/6
    memberid BIGINT NOT NULL, -- primary key part 4/6
    memberrole CHARACTER VARYING(255) NOT NULL, -- primary key part 5/6
    version BIGINT DEFAULT 0 NOT NULL, -- primary key part 2/6; references relations(id, version) part 2/2
    sequenceid INTEGER DEFAULT 0 NOT NULL -- primary key part 6/6
);
 
CREATE TABLE relationtags (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/3; references relations(id, version) part 1/2
    k CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL, -- primary key part 3/3
    v CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    version BIGINT NOT NULL -- primary key part 2/3; references relations(id, version) part 2/2
);
 
CREATE TABLE relations (
    id BIGINT DEFAULT 0 NOT NULL, -- primary key part 1/2
    changesetid BIGINT NOT NULL, -- references changesets(id)
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
    version BIGINT NOT NULL, -- primary key part 2/2
    visible BOOLEAN DEFAULT TRUE NOT NULL
);

CREATE TABLE countries (
    id INTEGER NOT NULL, -- autoincrement primary key
    code CHARACTER VARYING(2) NOT NULL,
    minlat DOUBLE PRECISION NOT NULL,
    maxlat DOUBLE PRECISION NOT NULL,
    minlon DOUBLE PRECISION NOT NULL,
    maxlon DOUBLE PRECISION NOT NULL
);

CREATE TABLE gpspoints (
    altitude DOUBLE PRECISION,
    trackid INTEGER NOT NULL,
    latitude INTEGER NOT NULL,
    longitude INTEGER NOT NULL,
    gpxid BIGINT NOT NULL, -- references gpx_files(id)
    timestamps TIMESTAMP WITHOUT TIME zone,
    tile BIGINT
);
 
CREATE TABLE gpxfiletags (
    gpxid BIGINT DEFAULT 0 NOT NULL, -- references gpx_files(id)
    tag CHARACTER VARYING(255) NOT NULL,
    id BIGINT NOT NULL -- autoincrement primary key
);
 
CREATE TABLE gpxfiles (
    id BIGINT NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    visible BOOLEAN DEFAULT TRUE NOT NULL,
    name CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    SIZE BIGINT,
    latitude DOUBLE PRECISION,
    longitude DOUBLE PRECISION,
    timestamps TIMESTAMP WITHOUT TIME zone NOT NULL,
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
 
CREATE TABLE clientapplications (
    id INTEGER NOT NULL, -- autoincrement primary key
    name CHARACTER VARYING(255),
    url CHARACTER VARYING(255),
    supporturl CHARACTER VARYING(255),
    callbackurl CHARACTER VARYING(255),
    KEY CHARACTER VARYING(50),
    secret CHARACTER VARYING(50),
    userid INTEGER, -- references users(id)
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone,
    allowreadprefs BOOLEAN DEFAULT FALSE NOT NULL,
    allowwriteprefs BOOLEAN DEFAULT FALSE NOT NULL,
    allowwritediary BOOLEAN DEFAULT FALSE NOT NULL,
    allowwriteapi BOOLEAN DEFAULT FALSE NOT NULL,
    allowreadgpx BOOLEAN DEFAULT FALSE NOT NULL,
    allowwritegpx BOOLEAN DEFAULT FALSE NOT NULL
);
 
CREATE TABLE diarycomments (
    id BIGINT NOT NULL, --autoincrement primary key
    diaryentryid BIGINT NOT NULL, -- references diary_entries(id)
    userid BIGINT NOT NULL,
    body text NOT NULL,
    createdat TIMESTAMP WITHOUT TIME zone NOT NULL,
    updatedat TIMESTAMP WITHOUT TIME zone NOT NULL
);
 
CREATE TABLE diaryentries (
    id BIGINT NOT NULL, --autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    title CHARACTER VARYING(255) NOT NULL,
    body text NOT NULL,
    createdat TIMESTAMP WITHOUT TIME zone NOT NULL,
    updatedat TIMESTAMP WITHOUT TIME zone NOT NULL,
    latitude DOUBLE PRECISION,
    longitude DOUBLE PRECISION,
    languagecode CHARACTER VARYING(255) DEFAULT 'en'::CHARACTER VARYING NOT NULL -- references languages(code)
);
 
CREATE TABLE friends (
    id BIGINT NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    frienduserid BIGINT NOT NULL -- references users(id)
);
 
CREATE TABLE languages (
    code CHARACTER VARYING(255) NOT NULL, -- primary key
    englishname CHARACTER VARYING(255) NOT NULL,
    nativename CHARACTER VARYING(255)
);
 
CREATE TABLE messages (
    id BIGINT NOT NULL, -- autoincrement primary key
    fromuserid BIGINT NOT NULL, -- references users(id)
    title CHARACTER VARYING(255) NOT NULL,
    body text NOT NULL,
    senton TIMESTAMP WITHOUT TIME zone NOT NULL,
    messageread BOOLEAN DEFAULT FALSE NOT NULL,
    touserid BIGINT NOT NULL, -- references users(id)
    touservisible BOOLEAN DEFAULT TRUE NOT NULL,
    fromuservisible BOOLEAN DEFAULT TRUE NOT NULL
);
 
CREATE TABLE oauthnonces (
    id INTEGER NOT NULL, -- autoincrement primary key
    nonce CHARACTER VARYING(255),
    timestamps INTEGER,
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE oauthtokens (
    id INTEGER NOT NULL, -- autoincrement primary key
    userid INTEGER, -- references users(id)
    TYPE CHARACTER VARYING(20),
    clientapplicationid INTEGER, -- references client_applications(id)
    token CHARACTER VARYING(50),
    secret CHARACTER VARYING(50),
    authorizedat TIMESTAMP WITHOUT TIME zone,
    invalidatedat TIMESTAMP WITHOUT TIME zone,
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone,
    allowreadprefs BOOLEAN DEFAULT FALSE NOT NULL,
    allowwriteprefs BOOLEAN DEFAULT FALSE NOT NULL,
    allowwritediary BOOLEAN DEFAULT FALSE NOT NULL,
    allowwriteapi BOOLEAN DEFAULT FALSE NOT NULL,
    allowreadgpx BOOLEAN DEFAULT FALSE NOT NULL,
    allowwritegpx BOOLEAN DEFAULT FALSE NOT NULL
);
 
CREATE TABLE schemamigrations (
    version CHARACTER VARYING(255) NOT NULL
);
 
CREATE TABLE sessions (
    id INTEGER NOT NULL, -- autoincrement primary key
    sessionid CHARACTER VARYING(255),
    DATA text,
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE userblocks (
    id INTEGER NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    creatorid BIGINT NOT NULL, -- references users(id)
    reason text NOT NULL,
    endsat TIMESTAMP WITHOUT TIME zone NOT NULL,
    needsview BOOLEAN DEFAULT FALSE NOT NULL,
    revokerid BIGINT, -- references users(id)
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone
);
 
CREATE TABLE userpreferences (
    userid BIGINT NOT NULL, -- primary key part 1/2; references users(id)
    k CHARACTER VARYING(255) NOT NULL, -- primary key part 2/2
    v CHARACTER VARYING(255) NOT NULL
);
 
CREATE TABLE userroles (
    id INTEGER NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    createdat TIMESTAMP WITHOUT TIME zone,
    updatedat TIMESTAMP WITHOUT TIME zone,
    ROLE BIGINT NOT NULL,
    granterid BIGINT NOT NULL -- references users(id)
);
 
CREATE TABLE usertokens (
    id BIGINT NOT NULL, -- autoincrement primary key
    userid BIGINT NOT NULL, -- references users(id)
    token CHARACTER VARYING(255) NOT NULL,
    expiry TIMESTAMP WITHOUT TIME zone NOT NULL,
    referer text
);
 
CREATE TABLE users (
    email CHARACTER VARYING(255) NOT NULL,
    id BIGINT NOT NULL, -- autoincrement primary key
    active INTEGER DEFAULT 0 NOT NULL,
    passcrypt CHARACTER VARYING(255) NOT NULL,
    creationtime TIMESTAMP WITHOUT TIME zone NOT NULL,
    displayname CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    datapublic BOOLEAN DEFAULT FALSE NOT NULL,
    description text DEFAULT ''::text NOT NULL,
    homelat DOUBLE PRECISION,
    homelon DOUBLE PRECISION,
    homezoom SMALLINT DEFAULT 3,
    nearby INTEGER DEFAULT 50,
    passsalt CHARACTER VARYING(255),
    image text,
    emailvalid BOOLEAN DEFAULT FALSE NOT NULL,
    newemail CHARACTER VARYING(255),
    visible BOOLEAN DEFAULT TRUE NOT NULL,
    creationip CHARACTER VARYING(255),
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
    ADD CONSTRAINT current_relation_members_pkey PRIMARY KEY (id, membertype, memberid, memberrole, sequenceid);
ALTER TABLE ONLY current_relation_tags
    ADD CONSTRAINT current_relation_tags_pkey PRIMARY KEY (id, k);
ALTER TABLE ONLY current_relations
    ADD CONSTRAINT current_relations_pkey PRIMARY KEY (id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_pkey PRIMARY KEY (id, sequenceid);
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
    ADD CONSTRAINT relation_members_pkey PRIMARY KEY (id, version, membertype, memberid, memberrole, sequenceid);
ALTER TABLE ONLY relation_tags
    ADD CONSTRAINT relation_tags_pkey PRIMARY KEY (id, version, k);
ALTER TABLE ONLY relations
    ADD CONSTRAINT relations_pkey PRIMARY KEY (id, version);
ALTER TABLE ONLY sessions
    ADD CONSTRAINT sessions_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_preferences
    ADD CONSTRAINT user_preferences_pkey PRIMARY KEY (userid, k);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_pkey PRIMARY KEY (id);
ALTER TABLE ONLY user_tokens
    ADD CONSTRAINT user_tokens_pkey PRIMARY KEY (id);
ALTER TABLE ONLY users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
ALTER TABLE ONLY way_nodes
    ADD CONSTRAINT way_nodes_pkey PRIMARY KEY (id, version, sequenceid);
ALTER TABLE ONLY way_tags
    ADD CONSTRAINT way_tags_pkey PRIMARY KEY (id, version, k);
ALTER TABLE ONLY ways
    ADD CONSTRAINT ways_pkey PRIMARY KEY (id, version);
ALTER TABLE ONLY conststring
    ADD CONSTRAINT conststring_pkey PRIMARY KEY (id);

ALTER TABLE ONLY changeset_tags
    ADD CONSTRAINT changeset_tags_id_fkey FOREIGN KEY (id) REFERENCES changesets(id);
ALTER TABLE ONLY changesets
    ADD CONSTRAINT changesets_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY client_applications
    ADD CONSTRAINT client_applications_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY current_node_tags
    ADD CONSTRAINT current_node_tags_id_fkey FOREIGN KEY (id) REFERENCES current_nodes(id);
ALTER TABLE ONLY current_nodes
    ADD CONSTRAINT current_nodes_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);
ALTER TABLE ONLY current_relation_members
    ADD CONSTRAINT current_relation_members_id_fkey FOREIGN KEY (id) REFERENCES current_relations(id);
ALTER TABLE ONLY current_relation_tags
    ADD CONSTRAINT current_relation_tags_id_fkey FOREIGN KEY (id) REFERENCES current_relations(id);
ALTER TABLE ONLY current_relations
    ADD CONSTRAINT current_relations_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_id_fkey FOREIGN KEY (id) REFERENCES current_ways(id);
ALTER TABLE ONLY current_way_nodes
    ADD CONSTRAINT current_way_nodes_node_id_fkey FOREIGN KEY (nodeid) REFERENCES current_nodes(id);
ALTER TABLE ONLY current_way_tags
    ADD CONSTRAINT current_way_tags_id_fkey FOREIGN KEY (id) REFERENCES current_ways(id);
ALTER TABLE ONLY current_ways
    ADD CONSTRAINT current_ways_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);
ALTER TABLE ONLY diary_comments
    ADD CONSTRAINT diary_comments_diary_entry_id_fkey FOREIGN KEY (diary_entryid) REFERENCES diary_entries(id);
ALTER TABLE ONLY diary_comments
    ADD CONSTRAINT diary_comments_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY diary_entries
    ADD CONSTRAINT diary_entries_language_code_fkey FOREIGN KEY (languagecode) REFERENCES languages(code);
ALTER TABLE ONLY diary_entries
    ADD CONSTRAINT diary_entries_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY friends
    ADD CONSTRAINT friends_friend_user_id_fkey FOREIGN KEY (friend_userid) REFERENCES users(id);
ALTER TABLE ONLY friends
    ADD CONSTRAINT friends_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY gps_points
    ADD CONSTRAINT gps_points_gpx_id_fkey FOREIGN KEY (gpxid) REFERENCES gpx_files(id);
ALTER TABLE ONLY gpx_file_tags
    ADD CONSTRAINT gpx_file_tags_gpx_id_fkey FOREIGN KEY (gpxid) REFERENCES gpx_files(id);
ALTER TABLE ONLY gpx_files
    ADD CONSTRAINT gpx_files_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY messages
    ADD CONSTRAINT messages_from_user_id_fkey FOREIGN KEY (fromuserid) REFERENCES users(id);
ALTER TABLE ONLY messages
    ADD CONSTRAINT messages_to_user_id_fkey FOREIGN KEY (touserid) REFERENCES users(id);
ALTER TABLE ONLY node_tags
    ADD CONSTRAINT node_tags_id_fkey FOREIGN KEY (id, version) REFERENCES nodes(id, version);
ALTER TABLE ONLY nodes
    ADD CONSTRAINT nodes_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);
ALTER TABLE ONLY oauth_tokens
    ADD CONSTRAINT oauth_tokens_client_application_id_fkey FOREIGN KEY (clientapplicationid) REFERENCES client_applications(id);
ALTER TABLE ONLY oauth_tokens
    ADD CONSTRAINT oauth_tokens_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY relation_members
    ADD CONSTRAINT relation_members_id_fkey FOREIGN KEY (id, version) REFERENCES relations(id, version);
ALTER TABLE ONLY relation_tags
    ADD CONSTRAINT relation_tags_id_fkey FOREIGN KEY (id, version) REFERENCES relations(id, version);
ALTER TABLE ONLY relations
    ADD CONSTRAINT relations_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_moderator_id_fkey FOREIGN KEY (creatorid) REFERENCES users(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_revoker_id_fkey FOREIGN KEY (revokerid) REFERENCES users(id);
ALTER TABLE ONLY user_blocks
    ADD CONSTRAINT user_blocks_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY user_preferences
    ADD CONSTRAINT user_preferences_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_granter_id_fkey FOREIGN KEY (granterid) REFERENCES users(id);
ALTER TABLE ONLY user_roles
    ADD CONSTRAINT user_roles_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY user_tokens
    ADD CONSTRAINT user_tokens_user_id_fkey FOREIGN KEY (userid) REFERENCES users(id);
ALTER TABLE ONLY way_nodes
    ADD CONSTRAINT way_nodes_id_fkey FOREIGN KEY (id, version) REFERENCES ways(id, version);
ALTER TABLE ONLY way_tags
    ADD CONSTRAINT way_tags_id_fkey FOREIGN KEY (id, version) REFERENCES ways(id, version);
ALTER TABLE ONLY ways
    ADD CONSTRAINT ways_changeset_id_fkey FOREIGN KEY (changesetid) REFERENCES changesets(id);

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
 
--ALTER TABLE acls ALTER COLUMN id SET DEFAULT NEXTVAL('acls_id_seq'::regclass);
--ALTER TABLE changesets ALTER COLUMN id SET DEFAULT NEXTVAL('changesets_id_seq'::regclass);
--ALTER TABLE client_applications ALTER COLUMN id SET DEFAULT NEXTVAL('client_applications_id_seq'::regclass);
--ALTER TABLE countries ALTER COLUMN id SET DEFAULT NEXTVAL('countries_id_seq'::regclass);
--ALTER TABLE current_nodes ALTER COLUMN id SET DEFAULT NEXTVAL('current_nodes_id_seq'::regclass);
--ALTER TABLE current_relations ALTER COLUMN id SET DEFAULT NEXTVAL('current_relations_id_seq'::regclass);
--ALTER TABLE current_ways ALTER COLUMN id SET DEFAULT NEXTVAL('current_ways_id_seq'::regclass);
--ALTER TABLE diary_comments ALTER COLUMN id SET DEFAULT NEXTVAL('diary_comments_id_seq'::regclass);
--ALTER TABLE diary_entries ALTER COLUMN id SET DEFAULT NEXTVAL('diary_entries_id_seq'::regclass);
--ALTER TABLE friends ALTER COLUMN id SET DEFAULT NEXTVAL('friends_id_seq'::regclass);
--ALTER TABLE gpx_file_tags ALTER COLUMN id SET DEFAULT NEXTVAL('gpx_file_tags_id_seq'::regclass);
--ALTER TABLE gpx_files ALTER COLUMN id SET DEFAULT NEXTVAL('gpx_files_id_seq'::regclass);
--ALTER TABLE messages ALTER COLUMN id SET DEFAULT NEXTVAL('messages_id_seq'::regclass);
--ALTER TABLE oauth_nonces ALTER COLUMN id SET DEFAULT NEXTVAL('oauth_nonces_id_seq'::regclass);
--ALTER TABLE oauth_tokens ALTER COLUMN id SET DEFAULT NEXTVAL('oauth_tokens_id_seq'::regclass);
--ALTER TABLE sessions ALTER COLUMN id SET DEFAULT NEXTVAL('sessions_id_seq'::regclass);
--ALTER TABLE user_blocks ALTER COLUMN id SET DEFAULT NEXTVAL('user_blocks_id_seq'::regclass);
--ALTER TABLE user_roles ALTER COLUMN id SET DEFAULT NEXTVAL('user_roles_id_seq'::regclass);
--ALTER TABLE user_tokens ALTER COLUMN id SET DEFAULT NEXTVAL('user_tokens_id_seq'::regclass);
--ALTER TABLE users ALTER COLUMN id SET DEFAULT NEXTVAL('users_id_seq'::regclass);
--ALTER TABLE conststring ALTER COLUMN id SET DEFAULT NEXTVAL('conststring_id_seq'::regclass);

CREATE INDEX acls_k_idx ON acls USING btree (k);
CREATE INDEX changeset_tags_id_idx ON changesettags USING btree (id);
CREATE INDEX changesets_bbox_idx ON changesets USING gist (minlat, maxlat, minlon, maxlon);
CREATE INDEX changesets_closed_at_idx ON changesets USING btree (closedat);
CREATE INDEX changesets_created_at_idx ON changesets USING btree (createdat);
CREATE INDEX changesets_user_id_idx ON changesets USING btree (userid);
CREATE UNIQUE INDEX countries_code_idx ON countries USING btree (code);
CREATE INDEX current_nodes_tile_idx ON currentnodes USING btree (tile);
CREATE INDEX current_nodes_timestamp_idx ON currentnodes USING btree (timestamps);
CREATE INDEX current_relation_members_member_idx ON currentrelation_members USING btree (membertype, memberid);
CREATE INDEX current_relations_timestamp_idx ON currentrelations USING btree (timestamps);
CREATE INDEX current_way_nodes_node_idx ON currentway_nodes USING btree (nodeid);
CREATE INDEX current_ways_timestamp_idx ON currentways USING btree (timestamps);
CREATE UNIQUE INDEX diary_comments_entry_id_idx ON diarycomments USING btree (diaryentryid, id);
CREATE INDEX friends_user_id_idx ON friends USING btree (userid);
CREATE INDEX gpx_file_tags_gpxid_idx ON gpxfiletags USING btree (gpxid);
CREATE INDEX gpx_file_tags_tag_idx ON gpxfiletags USING btree (tag);
CREATE INDEX gpx_files_timestamp_idx ON gpxfiles USING btree (timestamps);
CREATE INDEX gpx_files_user_id_idx ON gpxfiles USING btree (userid);
CREATE INDEX gpx_files_visible_visibility_idx ON gpxfiles USING btree (visible, visibility);
CREATE UNIQUE INDEX index_client_applications_on_key ON clientapplications USING btree (KEY);
CREATE UNIQUE INDEX index_oauth_nonces_on_nonce_and_timestamp ON oauthnonces USING btree (nonce, timestamps);
CREATE UNIQUE INDEX index_oauth_tokens_on_token ON oauthtokens USING btree (token);
CREATE INDEX index_user_blocks_on_user_id ON userblocks USING btree (userid);
CREATE INDEX messages_from_user_id_idx ON messages USING btree (fromuserid);
CREATE INDEX messages_to_user_id_idx ON messages USING btree (touserid);
CREATE INDEX nodes_changeset_id_idx ON nodes USING btree (changesetid);
CREATE INDEX nodes_tile_idx ON nodes USING btree (tile);
CREATE INDEX nodes_timestamp_idx ON nodes USING btree (timestamps);
CREATE INDEX points_gpxid_idx ON gpspoints USING btree (gpxid);
CREATE INDEX points_tile_idx ON gpspoints USING btree (tile);
CREATE INDEX relation_members_member_idx ON relationmembers USING btree (membertype, memberid);
CREATE INDEX relations_changeset_id_idx ON relations USING btree (changesetid);
CREATE INDEX relations_timestamp_idx ON relations USING btree (timestamps);
CREATE UNIQUE INDEX sessions_session_id_idx ON sessions USING btree (sessionid);
CREATE UNIQUE INDEX unique_schema_migrations ON schemamigrations USING btree (version);
CREATE INDEX user_id_idx ON friends USING btree (frienduserid);
CREATE UNIQUE INDEX user_roles_id_role_unique ON userroles USING btree (userid, ROLE);
CREATE UNIQUE INDEX user_tokens_token_idx ON usertokens USING btree (token);
CREATE INDEX user_tokens_user_id_idx ON usertokens USING btree (userid);
CREATE UNIQUE INDEX users_display_name_idx ON users USING btree (displayname);
CREATE UNIQUE INDEX users_email_idx ON users USING btree (email);
CREATE INDEX way_nodes_node_idx ON waynodes USING btree (nodeid);
CREATE INDEX ways_changeset_id_idx ON ways USING btree (changesetid);
CREATE INDEX ways_timestamp_idx ON ways USING btree (timestamps);
