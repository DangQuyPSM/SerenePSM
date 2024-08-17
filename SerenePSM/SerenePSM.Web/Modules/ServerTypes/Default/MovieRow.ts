﻿import { fieldsProxy } from "@serenity-is/corelib";
import { MovieKind } from "../Modules/Default.Movie.MovieKind";

export interface MovieRow {
    MovieId?: number;
    Title?: string;
    Description?: string;
    Storyline?: string;
    Year?: number;
    ReleaseDate?: string;
    Runtime?: number;
    Kind?: MovieKind;
}

export abstract class MovieRow {
    static readonly idProperty = 'MovieId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Default.Movie';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MovieRow>();
}