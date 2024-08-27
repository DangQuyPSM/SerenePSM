import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { Pfk7105Row } from "./Pfk7105Row";

export namespace Pfk7105Service {
    export const baseUrl = 'Default/Pfk7105';

    export declare function Create(request: SaveRequest<Pfk7105Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7105Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7105Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7105Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7105Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7105Row>>;

    export const Methods = {
        Create: "Default/Pfk7105/Create",
        Update: "Default/Pfk7105/Update",
        Delete: "Default/Pfk7105/Delete",
        Retrieve: "Default/Pfk7105/Retrieve",
        List: "Default/Pfk7105/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7105Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}