import { expect } from 'chai';
import {analyzeArray} from '../arrayAnalyzer.js';

describe('Analyze Array', () => {

    //it('Should return valid result with valid input', () => {
    //    const input = [1, 2, 3];
    //    const result = analyzeArray(input);
    //    const expected = {
    //        min: 1,
    //        max: 3,
    //        length: 3,
    //    };

     //   expect(result).is.deep.equal(expected);
    //});
    it('Should return an object with specific properties', ()=> {
        const input = [1, 2, 3];
        const result = analyzeArray(input);

        expect(result).to.be.an('object');
        expect(result).to.have.property('min');
        expect(result).to.have.property('max');
        expect(result).to.have.property('length');
    });

    it('Should return the highest positive number from an array of numbers', ()=> {
        const input = [1, 13, 7];
        expect(analyzeArray(input)).has.property('max', 13);
    });

    it('Should return the highest negative number from an array of numbers', ()=> {
        const input = [-7, -13, -11];
        expect(analyzeArray(input)).to.include({ 'max': -7 });
    });

    it('Should return the highest decimal number from an array of numbers', ()=> {
        const input = [3.11, 3.13, 3.12];
        expect(analyzeArray(input)).has.property('max', 3.13);
    });

    it('Should return result when single element array is given', ()=> {
        const input = [5];
        expect(analyzeArray(input)).to.include({
            min: 5,
            max: 5,
            length: 1,
        });
    });
    
    it('Should return valid result when equal elements array is given', ()=> {
        const input = [1, 1, 1];
        expect(analyzeArray(input)).to.include({
            min: 1,
            max: 1,
            length: 3,
        });
    });

    it('Should return the lowest positive number from an array of numbers', ()=> {
        const input = [1, 13, 7];
        expect(analyzeArray(input)).has.property('min', 1);
    });

    it('Should return the lowest negative number from an array of numbers', ()=> {
        const input = [-7, -13, -11];
        expect(analyzeArray(input)).to.include({ 'min': -13 });
    });

    it('Should return the lowest decimal number from an array of numbers', ()=> {
        const input = [3.11, -3.13, 3.12];
        expect(analyzeArray(input)).has.property('min', -3.13);
    });

    it('Should return the correct length', ()=> {
        const input = [1, 13, 7];
        expect(analyzeArray(input)).has.property('length', 3);
    });

    it('Should return undefined when non-number array is given', ()=> {
        expect(analyzeArray(['1', '2', '3'])).to.be.undefined;
        expect(analyzeArray(['true', 'false', 'true'])).to.be.undefined;
        expect(analyzeArray(['1', 2 , 3 ])).to.be.undefined;
        expect(analyzeArray([null, [] , 3 ])).to.be.undefined;
    });

    it('Should return undefined when empty array is given', ()=> {
        const input = [];
        expect(analyzeArray(input)).to.be.undefined;
    });

    it('Should return undefined when invalid input is given', ()=> {
        expect(analyzeArray()).to.be.undefined;
        expect(analyzeArray(undefined)).to.be.undefined;
        expect(analyzeArray(false)).to.be.undefined;
        expect(analyzeArray(1)).to.be.undefined;
        expect(analyzeArray(NaN)).to.be.undefined;
        expect(analyzeArray({'0': 1})).to.be.undefined;
        expect(analyzeArray('')).to.be.undefined;
    });
});