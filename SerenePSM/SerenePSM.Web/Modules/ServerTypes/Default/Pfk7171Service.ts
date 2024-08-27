import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { Pfk7171Row } from "./Pfk7171Row";

export namespace Pfk7171Service {
    export const baseUrl = 'Default/Pfk7171';

    export declare function Create(request: SaveRequest<Pfk7171Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7171Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7171Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7171Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7171Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7171Row>>;

    export const Methods = {
        Create: "Default/Pfk7171/Create",
        Update: "Default/Pfk7171/Update",
        Delete: "Default/Pfk7171/Delete",
        Retrieve: "Default/Pfk7171/Retrieve",
        List: "Default/Pfk7171/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7171Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}