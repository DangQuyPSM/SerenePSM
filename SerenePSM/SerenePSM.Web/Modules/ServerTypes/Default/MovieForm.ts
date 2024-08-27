﻿import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, TextAreaEditor, IntegerEditor, DateEditor, EnumEditor } from "serenity.corelib";
import { MovieKind } from "../Modules/Default.Movie.MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    Storyline: TextAreaEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
    Kind: EnumEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'Default.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;
            var w4 = EnumEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w1,
                'Storyline', w1,
                'Year', w2,
                'ReleaseDate', w3,
                'Runtime', w2,
                'Kind', w4
            ]);
        }
    }
}

[MovieKind]; // referenced types