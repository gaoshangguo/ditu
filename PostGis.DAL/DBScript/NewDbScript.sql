CREATE TABLE ChangesetTags (
    Id BIGINT NOT NULL, -- references changesets(id)
    K CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    V CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL
);
 
CREATE TABLE Changesets (
    Id BIGINT NOT NULL, -- autoincrement primary key
    UserId BIGINT NOT NULL, -- references users(id)    
    MinLat INTEGER,
    MaxLon INTEGER,
    MinLon INTEGER,
    MaxLat INTEGER,
    CreatedAt TIMESTAMP WITHOUT TIME zone NOT NULL,
    ClosedAt TIMESTAMP WITHOUT TIME zone NOT NULL,
    NumChanges INTEGER DEFAULT 0 NOT NULL
);

CREATE TABLE Users (
    Id BIGINT NOT NULL, -- autoincrement primary key
    Email CHARACTER VARYING(255) NOT NULL,
    NewEmail CHARACTER VARYING(255),
    EmailValid BOOLEAN DEFAULT FALSE NOT NULL,
    HomeLat DOUBLE PRECISION,
    HomeLon DOUBLE PRECISION,
    HomeZoom SMALLINT DEFAULT 3,
    Active INTEGER DEFAULT 0 NOT NULL,
    CreationTime TIMESTAMP WITHOUT TIME zone NOT NULL,
    CreationIp CHARACTER VARYING(255),
    PassCrypt CHARACTER VARYING(255) NOT NULL,
    PassSalt CHARACTER VARYING(255),
    DisplayName CHARACTER VARYING(255) DEFAULT ''::CHARACTER VARYING NOT NULL,
    Image text,
    Visible BOOLEAN DEFAULT TRUE NOT NULL,
    DataPublic BOOLEAN DEFAULT FALSE NOT NULL,
    Languages CHARACTER VARYING(255),
    Description text DEFAULT ''::text NOT NULL,    
    Nearby INTEGER DEFAULT 50
);

CREATE TABLE Acls (
    Id INTEGER NOT NULL, -- autoincrement primary key
    K CHARACTER VARYING(255) NOT NULL,
    V CHARACTER VARYING(255),
    Address inet NOT NULL,
    Netmask inet NOT NULL
);